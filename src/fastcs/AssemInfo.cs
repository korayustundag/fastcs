using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace fastcs
{
    internal class AssemInfo
    {
        public CodeAttributeDeclaration Description()
        {
            var attr = new CodeTypeReference(typeof(AssemblyDescriptionAttribute));
            return new CodeAttributeDeclaration(attr, new CodeAttributeArgument(
                new CodePrimitiveExpression("Compiled with FastCS")));
        }
        public CodeAttributeDeclaration Version(string version)
        {
            var attr = new CodeTypeReference(typeof(AssemblyVersionAttribute));
            return new CodeAttributeDeclaration(attr, new CodeAttributeArgument(
                new CodePrimitiveExpression(version)));
        }
        public CodeAttributeDeclaration FileVersion(string version)
        {
            var attr = new CodeTypeReference(typeof(AssemblyFileVersionAttribute));
            return new CodeAttributeDeclaration(attr, new CodeAttributeArgument(
                new CodePrimitiveExpression(version)));
        }
        public CodeAttributeDeclaration Title(string title)
        {
            var attr = new CodeTypeReference(typeof(AssemblyTitleAttribute));
            return new CodeAttributeDeclaration(attr, new CodeAttributeArgument(
                new CodePrimitiveExpression(title)));
        }
        public CodeAttributeDeclaration ProductName(string name)
        {
            var attr = new CodeTypeReference(typeof(AssemblyProductAttribute));
            return new CodeAttributeDeclaration(attr, new CodeAttributeArgument(
                new CodePrimitiveExpression(name)));
        }
        public CodeAttributeDeclaration CompanyName(string name)
        {
            var attr = new CodeTypeReference(typeof(AssemblyCompanyAttribute));
            return new CodeAttributeDeclaration(attr, new CodeAttributeArgument(
                new CodePrimitiveExpression(name)));
        }
        public CodeAttributeDeclaration Copyright(string name)
        {
            var attr = new CodeTypeReference(typeof(AssemblyCopyrightAttribute));
            return new CodeAttributeDeclaration(attr, new CodeAttributeArgument(
                new CodePrimitiveExpression(name)));
        }
    }
}
