using System;
using RazorEngine;
using RazorEngine.Templating;
using System.Security;

namespace RazorReport {
    public class Engine<T> : IEngine<T> {

        public void Compile(string preparedTemplate, string templateName)
        {
            Engine.Razor.Compile(preparedTemplate, templateName, typeof(T));
        }

        public string Run(T model, string templateName)
        {
            return Engine.Razor.Run(templateName, typeof(T), model);
        }

        public string Parse(string template, T model)
        {
            return Engine.Razor.RunCompile(template, typeof(T), model);
        }

        //public void Compile(string preparedTemplate, string templateName) {
        //    Razor.Compile<T>(preparedTemplate, templateName);
        //}

        //public string Run(T model, string templateName) {
        //    return Razor.Run(templateName, model);
        //}

        //public string Parse (string template, T model) {
        //    return Razor.Parse<T>(template, model);
        //}
    }
}
