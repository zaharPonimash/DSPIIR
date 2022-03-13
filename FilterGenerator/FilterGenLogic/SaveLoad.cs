using AI.DSP.IIR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace FilterGenLogic
{
    public static class SaveLoad
    {
        // Сохранение фильтра в формате AI
        public static void SaveFilterAsBinary(this MainLogic logic, string path, string projectName)
        {
            IIRFilter iIRFilter = new IIRFilter(logic.a, logic.b)
            {
                Name = string.Format("filter {0}, freq cut {1}, project {2}", logic.filterType, logic.fCut, projectName)
            };
            iIRFilter.Save(path);
        }

        // Сохранение фильтра в формате AI
        public static void SaveFilterAsJson(this MainLogic logic, string path, string projectName)
        {
            IIRFilter iIRFilter = new IIRFilter(logic.a, logic.b)
            {
                Name = string.Format("filter {0}, freq cut {1}, project {2}", logic.filterType, logic.fCut, projectName)
            };
            
            var json = JsonConvert.SerializeObject(iIRFilter);
            File.WriteAllText(path, json);
        }


        // Загрузка фильтра бинарный
        public static void LoadFilterAsBinary(this MainLogic logic, string path)
        {
            IIRFilter iIRFilter = IIRFilter.Load(path);
            SetParamLoad(logic, iIRFilter);
        }    
        
        // Загрузка фильтра json
        public static void LoadFilterAsJson(this MainLogic logic, string path)
        {
            string json = File.ReadAllText(path);
            IIRFilterLoaderJson iIRFilterLoader =  JsonConvert.DeserializeObject<IIRFilterLoaderJson>(json);
            IIRFilter iIRFilter = new IIRFilter(iIRFilterLoader.A, iIRFilterLoader.B)
            {
                Name = iIRFilterLoader.Name
            };
            SetParamLoad(logic, iIRFilter);
        }

        private static void SetParamLoad(MainLogic logic, IIRFilter iIRFilter)
        {
            logic.a = iIRFilter.A;
            logic.a = logic.a.CutAndZero(logic.a.Count / 2);
            logic.b = iIRFilter.B;
            logic.b = logic.b.CutAndZero(logic.b.Count / 2);
        }
    }

    [Serializable]
    public class IIRFilterLoaderJson
    {
        public string Name { get; set; }
        public double[] A { get; set; }
        public double[] B { get; set; }
    }
}
