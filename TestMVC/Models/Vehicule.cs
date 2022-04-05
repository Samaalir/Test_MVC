using Microsoft.CSharp;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
//using System.CodeDom;
//using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TestMVC.Models
{
    public class Vehicule
    {
        public void BoostSpeed(double boost)
        {
            Console.WriteLine($"Booost {boost}");
        }
    }
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        dynamic obj = Activator.CreateInstance(typeof(Vehicule));
    //        try
    //        {
    //            obj.BoostSpeed(120);
    //        }
    //        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    //        {

    //            throw ex;
    //        }
    //    }
    //    private static void WriteGeneratedClassToFile(string fileFullPath)
    //    {
    //        var codeCompileUnit = new CodeCompileUnit();

    //        var skillValueNamespace = new CodeNamespace("Skil1Value");
    //        skillValueNamespace.Imports.Add(new CodeNamespaceImport("System"));
    //        codeCompileUnit.Namespaces.Add(skillValueNamespace);

    //        var loggerClass = new CodeTypeDeclaration("LoggerOutput");
    //        skillValueNamespace.Types.Add(loggerClass);

    //        var loggerMethod = new CodeMemberMethod()
    //        {
    //            ReturnType = new CodeTypeReference(typeof(void)),
    //            Name = "Loghelloor1d"
    //        };
    //        loggerClass.Members.Add(loggerMethod) ;

    //        var methodToinvoke = new CodeMethodInvokeExpression(
    //        new CodeTypeReferenceExpression("Console"),
    //        "WriteLine",
    //        new CodePrimitiveExpression("Hello, World!"));
    //        loggerMethod.Statements.Add(methodToinvoke);

    //        // TO00: insert code here
    //        var CodeProvider = new CSharpCodeProvider();
    //        using (StreamWriter sw = new System.IO.StreamWriter("C://Users//samaa//Downloads//WhatsApp_files", false))
    //        {
    //            var options = new CodeGeneratorOptions();
    //            CodeProvider.GenerateCodeFromCompileUnit(codeCompileUnit, sw, options);
    //        }
    //    }
    //}
}
