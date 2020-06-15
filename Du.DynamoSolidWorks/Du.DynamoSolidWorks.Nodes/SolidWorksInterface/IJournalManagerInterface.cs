using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IJournalManagerObject
    {
        public IJournalManager IJournalManagerInstance { get; set; }
        public IJournalManagerObject(IJournalManager IJournalManagerinstance)
        {
            IJournalManagerInstance = IJournalManagerinstance;
        }
    }
    public static class IJournalManagerInterface
    {
        public static Boolean RunCommand(IJournalManagerObject IJournalManagerinstance, Int32 CommandID, String NewTitle)
        {
            return IJournalManagerinstance.IJournalManagerInstance.RunCommand(CommandID, NewTitle);
        }
        public static void RecordDialogControl(IJournalManagerObject IJournalManagerinstance, String DialogId, String ResourceID)
        {
            IJournalManagerinstance.IJournalManagerInstance.RecordDialogControl(DialogId, ResourceID);
        }
        public static void RecordDialogControlText(IJournalManagerObject IJournalManagerinstance, String DialogId, String ResourceID, String Value)
        {
            IJournalManagerinstance.IJournalManagerInstance.RecordDialogControlText(DialogId, ResourceID, Value);
        }
        public static void RecordDialogButtonState(IJournalManagerObject IJournalManagerinstance, String DialogId, String ResourceID, Int32 Value)
        {
            IJournalManagerinstance.IJournalManagerInstance.RecordDialogButtonState(DialogId, ResourceID, Value);
        }
        public static void SetKeyBoardState(IJournalManagerObject IJournalManagerinstance, String KeyState)
        {
            IJournalManagerinstance.IJournalManagerInstance.SetKeyBoardState(KeyState);
        }
        public static Boolean ImportSwSettings(IJournalManagerObject IJournalManagerinstance, String FileName)
        {
            return IJournalManagerinstance.IJournalManagerInstance.ImportSwSettings(FileName);
        }
        public static Boolean ExportSwSettings(IJournalManagerObject IJournalManagerinstance, String FileName)
        {
            return IJournalManagerinstance.IJournalManagerInstance.ExportSwSettings(FileName);
        }
        public static void ClickDialogControl(IJournalManagerObject IJournalManagerinstance, String DialogId, String ResourceID)
        {
            IJournalManagerinstance.IJournalManagerInstance.ClickDialogControl(DialogId, ResourceID);
        }
        public static String GetDialogControlText(IJournalManagerObject IJournalManagerinstance, String DialogId, String ResourceID)
        {
            return IJournalManagerinstance.IJournalManagerInstance.GetDialogControlText(DialogId, ResourceID);
        }
        public static void SetDialogControlText(IJournalManagerObject IJournalManagerinstance, String DialogId, String ResourceID, String Value)
        {
            IJournalManagerinstance.IJournalManagerInstance.SetDialogControlText(DialogId, ResourceID, Value);
        }
        public static Int32 GetDialogButtonState(IJournalManagerObject IJournalManagerinstance, String DialogId, String ResourceID)
        {
            return IJournalManagerinstance.IJournalManagerInstance.GetDialogButtonState(DialogId, ResourceID);
        }
        public static void SetDialogButtonState(IJournalManagerObject IJournalManagerinstance, String DialogId, String ResourceID, Int32 Value)
        {
            IJournalManagerinstance.IJournalManagerInstance.SetDialogButtonState(DialogId, ResourceID, Value);
        }
        public static void FileDrop(IJournalManagerObject IJournalManagerinstance, String FilePath)
        {
            IJournalManagerinstance.IJournalManagerInstance.FileDrop(FilePath);
        }
        public static void WriteToJournalFile(IJournalManagerObject IJournalManagerinstance, String JournalText)
        {
            IJournalManagerinstance.IJournalManagerInstance.WriteToJournalFile(JournalText);
        }
        public static void ShowJournalDialog(IJournalManagerObject IJournalManagerinstance, Int32 ShowDlg)
        {
            IJournalManagerinstance.IJournalManagerInstance.ShowJournalDialog(ShowDlg);
        }
        public static void WriteJournalToMacro(IJournalManagerObject IJournalManagerinstance, String MacroPath)
        {
            IJournalManagerinstance.IJournalManagerInstance.WriteJournalToMacro(MacroPath);
        }
        public static Boolean RunXMLCommand(IJournalManagerObject IJournalManagerinstance, String XML)
        {
            return IJournalManagerinstance.IJournalManagerInstance.RunXMLCommand(XML);
        }
        public static void MakeCOMCall(IJournalManagerObject IJournalManagerinstance, String ClassID, String MethodName)
        {
            IJournalManagerinstance.IJournalManagerInstance.MakeCOMCall(ClassID, MethodName);
        }
        public static void RecordCOMCall(IJournalManagerObject IJournalManagerinstance, String ClassID, String MethodName)
        {
            IJournalManagerinstance.IJournalManagerInstance.RecordCOMCall(ClassID, MethodName);
        }
        public static void FileDropAt(IJournalManagerObject IJournalManagerinstance, String FilePath, Double X, Double Y, Double Z)
        {
            IJournalManagerinstance.IJournalManagerInstance.FileDropAt(FilePath, X, Y, Z);
        }
        public static void RecordKeyBoardState(IJournalManagerObject IJournalManagerinstance, String KeyState)
        {
            IJournalManagerinstance.IJournalManagerInstance.RecordKeyBoardState(KeyState);
        }
        public static IModelViewObject GetModelView(IJournalManagerObject IJournalManagerinstance, String ModelName, Int32 WindowID, Int32 Row, Int32 Column)
        {
            return new IModelViewObject(IJournalManagerinstance.IJournalManagerInstance.GetModelView(ModelName, WindowID, Row, Column));
        }
    }
}