using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MoonSharp;
using MoonSharp.Interpreter;
using System.ComponentModel;
using Newtonsoft.Json;
using WindowsApplication1.MacroLib;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public class MacroManager
    {
        public static MacroManager Instance { get; set; }

        public BindingList<Macro> macros = new();
        
        public MacroManager() {
            Instance = this;
            
            // Load macros from %appdata%/Local/HHTXT/macros.json
            // If file doesn't exist, create it
            // If file is corrupted, create a new one

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/HHTXT/")) {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/HHTXT/");
            }

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/HHTXT/macros.json")) {
                var fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/HHTXT/macros.json");
                fs.Write(Encoding.UTF8.GetBytes("[]"), 0, 2);
                fs.Flush();
                fs.Close();
            }

            try
            {
                var json = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/HHTXT/macros.json");
                macros = JsonConvert.DeserializeObject<BindingList<Macro>>(json);
            }
            catch
            {
                // File is corrupted, create a new one
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/HHTXT/macros.json");
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/HHTXT/macros.json", "[]");
                macros = new();
            }
        }

        public void InvokeEvent(MacroTrigger trigger, params KeyValuePair<string, object>[] args)
        {
            Debug.WriteLine("Invoking " + trigger.ToString());
            foreach (var macro in macros)
            {
                if(macro.trigger == trigger)
                {
                    if(macro.TargetFunction == null)
                    {
                        macro.Recompile();
                    }

                    Debug.WriteLine(macro.name + " invoked");

                    try
                    {
                        foreach (var arg in args)
                        {
                            macro.Compiled.Globals[arg.Key] = arg.Value;
                        }
                        
                        macro.TargetFunction.Function.Call();
                    }catch(Exception e)
                    {
                        MessageBox.Show($@"Macro '{macro.name}' invocation failed:
{e.Message}

{e.StackTrace}");
                    }
                }
            }
        }

        public void SaveToJson()
        {
            var json = JsonConvert.SerializeObject(macros, Formatting.Indented, new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            });
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/HHTXT/macros.json", json);
        }
    }

    public class Macro
    {
        public Guid macroGuid;
        public string name;
        public string code;
        public MacroTrigger trigger;

        public string Name { get => name; }

        [JsonIgnore]
        public Script Compiled { get; private set; }
        [JsonIgnore]
        public DynValue TargetFunction { get; private set; }

        public void Recompile()
        {
            Compiled = new Script();

            var doc = UserData.Create(new Document());
            Compiled.Globals.Set("document", doc);

            try
            {
                TargetFunction = Compiled.LoadString(code);
            }catch(Exception e)
            {
                MessageBox.Show($@"Macro '{name}' compilation failed:
{e.Message}: {e.StackTrace}
", "Macro Compilation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Macro()
        {
            macroGuid = Guid.NewGuid();
        }
    }

    public enum MacroTrigger
    {
        ON_KEY_DOWN,
        BEFORE_SAVING,
        ON_START,
        CONTENT_CHANGED
    }

    public class MacroTriggerHelpers
    {
        // not used rn
    }
}
