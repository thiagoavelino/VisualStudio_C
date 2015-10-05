using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter8 {
    class CodeDomExample {
        static void MainCodeDomExample() {
            CodeNamespace codeNamespace = new CodeNamespace("Reflection");
            codeNamespace.Imports.Add(new CodeNamespaceImport("System"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Collections.Generic"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Linq"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Text"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Threading.Tasks"));

            CodeTypeDeclaration targetClass = new CodeTypeDeclaration("Calculator");
            targetClass.IsClass = true;
            targetClass.TypeAttributes = TypeAttributes.Public;
            //Add the class to the namespace.
            codeNamespace.Types.Add(targetClass);


            CodeMemberField xField = new CodeMemberField();
            xField.Name = "x";
            xField.Type = new CodeTypeReference(typeof(double));
            targetClass.Members.Add(xField);

            CodeMemberField yField = new CodeMemberField();
            yField.Name = "y";
            yField.Type = new CodeTypeReference(typeof(double));
            targetClass.Members.Add(yField);

            //X Property
            CodeMemberProperty xProperty = new CodeMemberProperty();
            xProperty.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            xProperty.Name = "X";
            xProperty.HasGet = true;
            xProperty.HasSet = true;
            xProperty.Type = new CodeTypeReference(typeof(System.Double));
            xProperty.GetStatements.Add(new CodeMethodReturnStatement(
            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "x")));
            xProperty.SetStatements.Add(new CodeAssignStatement(
            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "x"),
            new CodePropertySetValueReferenceExpression()));
            targetClass.Members.Add(xProperty);
            //Y Property
            CodeMemberProperty yProperty = new CodeMemberProperty();
            yProperty.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            yProperty.Name = "Y";
            yProperty.HasGet = true;
            yProperty.HasSet = true;
            yProperty.Type = new CodeTypeReference(typeof(System.Double));
            yProperty.GetStatements.Add(new CodeMethodReturnStatement(
            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "y")));
            yProperty.SetStatements.Add(new CodeAssignStatement(
            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "y"),
            new CodePropertySetValueReferenceExpression()));
            targetClass.Members.Add(yProperty);

            CodeMemberMethod divideMethod = new CodeMemberMethod();
            divideMethod.Name = "Divide";
            divideMethod.ReturnType = new CodeTypeReference(typeof(double));
            divideMethod.Attributes = MemberAttributes.Public | MemberAttributes.Final;

            CodeConditionStatement ifLogic = new CodeConditionStatement();
            ifLogic.Condition = new CodeBinaryOperatorExpression(
            new CodeFieldReferenceExpression(
            new CodeThisReferenceExpression(), yProperty.Name),
            CodeBinaryOperatorType.ValueEquality,
            new CodePrimitiveExpression(0));
            ifLogic.TrueStatements.Add(new CodeMethodReturnStatement(
            new CodePrimitiveExpression(0)));
            ifLogic.FalseStatements.Add(new CodeMethodReturnStatement(
            new CodeBinaryOperatorExpression(
            new CodeFieldReferenceExpression(
            new CodeThisReferenceExpression(), xProperty.Name),
            CodeBinaryOperatorType.Divide,
            new CodeFieldReferenceExpression(
            new CodeThisReferenceExpression(), yProperty.Name))));
            divideMethod.Statements.Add(ifLogic);
        }
    }
}
