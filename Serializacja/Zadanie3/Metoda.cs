using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    internal class Metoda
    {
        public string Name { get; set; }
        public bool IsVirtual { get; set; }
        public bool IsAbstract { get; set; }
        public string ReturnType { get; set; }
        public string Params { get; set; }
        public int _paramsCount = 0;

        public Metoda(string name, bool isVirtual, bool isAbstract, string returnType, string @params)
        {
            Name = name;
            IsVirtual = isVirtual;
            IsAbstract = isAbstract;
            ReturnType = returnType;
            Params = @params;
            _paramsCount = GetParamsCount();
        }


        private int GetParamsCount()
        {
            if (string.IsNullOrEmpty(Params))
                return 0;

            if (!Params.Contains(","))
                return 1;

            return Params.Split(',').Length;
        }


        public string ToString(bool viewConsole = false)
        {
            var fields = GetType().GetProperties();

            var props = new List<string>();

            foreach (var field in fields)
            {
                if(viewConsole && field.Name == nameof(Params))
                {
                    props.Add(_paramsCount.ToString());
                }
                else
                {
                    props.Add(field.GetValue(this).ToString());
                }

                
            }

            return String.Join(';', props.ToArray());
        }
    }
}
