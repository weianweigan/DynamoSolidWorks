using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISldWorksObject
    {
        public ISldWorks ISldWorksInstance { get; set; }
        public ISldWorksObject(ISldWorks ISldWorksinstance)
        {
            ISldWorksInstance = ISldWorksinstance;
        }
    }
    public static class ISldWorksInterface
    {
        public static String GetSSOFormattedURL(ISldWorksObject ISldWorksinstance, String TargetUrl)
        {
            return ISldWorksinstance.ISldWorksInstance.GetSSOFormattedURL(TargetUrl);
        }
        public static IModelDoc2Object OpenDoc7(ISldWorksObject ISldWorksinstance, Object Specification)
        {
            return new IModelDoc2Object(ISldWorksinstance.ISldWorksInstance.OpenDoc7(Specification));
        }
        public static Boolean BlockSkinning(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.BlockSkinning();
        }
        public static Boolean ResumeSkinning(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.ResumeSkinning();
        }
        public static void SetMultipleFilenamesPrompt(ISldWorksObject ISldWorksinstance, Object FileName)
        {
            ISldWorksinstance.ISldWorksInstance.SetMultipleFilenamesPrompt(FileName);
        }
        public static Boolean GetPreviewBitmapFile(ISldWorksObject ISldWorksinstance, String DocumentPath, String ConfigName, String BitMapFile)
        {
            return ISldWorksinstance.ISldWorksInstance.GetPreviewBitmapFile(DocumentPath, ConfigName, BitMapFile);
        }
        public static Int32 DragToolbarButtonFromCommandID(ISldWorksObject ISldWorksinstance, Int32 CommandID, Int32 TargetToolbar, Int32 TargetIndex)
        {
            return ISldWorksinstance.ISldWorksInstance.DragToolbarButtonFromCommandID(CommandID, TargetToolbar, TargetIndex);
        }
        public static Int32 AddMenuItem4(ISldWorksObject ISldWorksinstance, Int32 DocumentType, Int32 Cookie, String MenuItem, Int32 Position, String MenuCallback, String MenuEnableMethod, String HintString, String BitmapFilePath)
        {
            return ISldWorksinstance.ISldWorksInstance.AddMenuItem4(DocumentType, Cookie, MenuItem, Position, MenuCallback, MenuEnableMethod, HintString, BitmapFilePath);
        }
        public static Int32 AddMenuPopupItem3(ISldWorksObject ISldWorksinstance, Int32 DocumentType, Int32 Cookie, Int32 SelectType, String PopupItemName, String MenuCallback, String MenuEnableMethod, String HintString, String CustomNames)
        {
            return ISldWorksinstance.ISldWorksInstance.AddMenuPopupItem3(DocumentType, Cookie, SelectType, PopupItemName, MenuCallback, MenuEnableMethod, HintString, CustomNames);
        }
        //public static void GetBuildNumbers(ISldWorksObject ISldWorksinstance, String& BaseVersion, String& CurrentVersion)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetBuildNumbers(BaseVersion, CurrentVersion);
        //}
        public static Int32 RegisterTrackingDefinition(ISldWorksObject ISldWorksinstance, String Name)
        {
            return ISldWorksinstance.ISldWorksInstance.RegisterTrackingDefinition(Name);
        }
        public static Boolean SetNewFilename(ISldWorksObject ISldWorksinstance, String FileName)
        {
            return ISldWorksinstance.ISldWorksInstance.SetNewFilename(FileName);
        }
        public static String GetCurrentFileUser(ISldWorksObject ISldWorksinstance, String FilePathName)
        {
            return ISldWorksinstance.ISldWorksInstance.GetCurrentFileUser(FilePathName);
        }
        public static Object GetMacroMethods(ISldWorksObject ISldWorksinstance, String FilePathName, Int32 Filter)
        {
            return ISldWorksinstance.ISldWorksInstance.GetMacroMethods(FilePathName, Filter);
        }
        public static void EnablePhotoWorksProgressiveRender(ISldWorksObject ISldWorksinstance, Boolean BEnable)
        {
            ISldWorksinstance.ISldWorksInstance.EnablePhotoWorksProgressiveRender(BEnable);
        }
        public static Boolean RunAttachedMacro(ISldWorksObject ISldWorksinstance, String FileName, String ModuleName, String ProcedureName)
        {
            return ISldWorksinstance.ISldWorksInstance.RunAttachedMacro(FileName, ModuleName, ProcedureName);
        }
        //public static Boolean RunMacro2(ISldWorksObject ISldWorksinstance, String FilePathName, String ModuleName, String ProcedureName, Int32 Options, Int32& Error)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.RunMacro2(FilePathName, ModuleName, ProcedureName, Options, Error);
        //}
        public static Boolean IsCommandEnabled(ISldWorksObject ISldWorksinstance, Int32 CommandID)
        {
            return ISldWorksinstance.ISldWorksInstance.IsCommandEnabled(CommandID);
        }
        public static Int32 GetDocumentCount(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetDocumentCount();
        }
        public static Object GetDocuments(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetDocuments();
        }
        public static IModelDoc2Object IGetDocuments(ISldWorksObject ISldWorksinstance, Int32 NumDocuments)
        {
            return new IModelDoc2Object(ISldWorksinstance.ISldWorksInstance.IGetDocuments(NumDocuments));
        }
        public static IModelViewObject GetModelView(ISldWorksObject ISldWorksinstance, String ModelName, Int32 WindowID, Int32 Row, Int32 Column)
        {
            return new IModelViewObject(ISldWorksinstance.ISldWorksInstance.GetModelView(ModelName, WindowID, Row, Column));
        }
        public static Int32 ResetUntitledCount(ISldWorksObject ISldWorksinstance, Int32 PartValue, Int32 AssemValue, Int32 DrawingValue)
        {
            return ISldWorksinstance.ISldWorksInstance.ResetUntitledCount(PartValue, AssemValue, DrawingValue);
        }
        public static Boolean GetToolbarVisibility(ISldWorksObject ISldWorksinstance, Int32 Toolbar)
        {
            return ISldWorksinstance.ISldWorksInstance.GetToolbarVisibility(Toolbar);
        }
        public static void SetToolbarVisibility(ISldWorksObject ISldWorksinstance, Int32 Toolbar, Boolean Visibility)
        {
            ISldWorksinstance.ISldWorksInstance.SetToolbarVisibility(Toolbar, Visibility);
        }
        //public static Object GetLastSaveError(ISldWorksObject ISldWorksinstance, Object& FilePath, Object& ErrorCode)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetLastSaveError(FilePath, ErrorCode);
        //}
        public static Int32 RegisterThirdPartyPopupMenu(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.RegisterThirdPartyPopupMenu();
        }
        public static Boolean AddItemToThirdPartyPopupMenu(ISldWorksObject ISldWorksinstance, Int32 RegisterId, Int32 DocType, String Item, String CallbackFcnAndModule, String CustomName, String HintString, String BitmapFileName, Int32 MenuItemTypeOption)
        {
            return ISldWorksinstance.ISldWorksInstance.AddItemToThirdPartyPopupMenu(RegisterId, DocType, Item, CallbackFcnAndModule, CustomName, HintString, BitmapFileName, MenuItemTypeOption);
        }
        public static Boolean ShowThirdPartyPopupMenu(ISldWorksObject ISldWorksinstance, Int32 RegisterId, Int32 Posx, Int32 Posy)
        {
            return ISldWorksinstance.ISldWorksInstance.ShowThirdPartyPopupMenu(RegisterId, Posx, Posy);
        }
        public static Int32 IsSame(ISldWorksObject ISldWorksinstance, Object Object1, Object Object2)
        {
            return ISldWorksinstance.ISldWorksInstance.IsSame(Object1, Object2);
        }
        //public static Boolean GetButtonPosition(ISldWorksObject ISldWorksinstance, Int32 PointAt, Int32& LocX, Int32& LocY)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetButtonPosition(PointAt, LocX, LocY);
        //}
        public static Boolean RunJournalCmd(ISldWorksObject ISldWorksinstance, String Cmd)
        {
            return ISldWorksinstance.ISldWorksInstance.RunJournalCmd(Cmd);
        }
        public static Boolean SetThirdPartyPopupMenuState(ISldWorksObject ISldWorksinstance, Int32 RegisterId, Boolean IsActive)
        {
            return ISldWorksinstance.ISldWorksInstance.SetThirdPartyPopupMenuState(RegisterId, IsActive);
        }
        public static Boolean IsBackgroundProcessingCompleted(ISldWorksObject ISldWorksinstance, String FilePath)
        {
            return ISldWorksinstance.ISldWorksInstance.IsBackgroundProcessingCompleted(FilePath);
        }
        public static void ShowBubbleTooltipAt2(ISldWorksObject ISldWorksinstance, Int32 PointX, Int32 PointY, Int32 ArrowPos, String TitleString, String MessageString, Int32 TitleBitmapID, String TitleBitmap, String UrlLoc, Int32 Cookie, Int32 LinkStringID, String LinkString, String CallBack)
        {
            ISldWorksinstance.ISldWorksInstance.ShowBubbleTooltipAt2(PointX, PointY, ArrowPos, TitleString, MessageString, TitleBitmapID, TitleBitmap, UrlLoc, Cookie, LinkStringID, LinkString, CallBack);
        }
        public static Boolean RemoveItemFromThirdPartyPopupMenu(ISldWorksObject ISldWorksinstance, Int32 RegisterId, Int32 DocType, String Item, Int32 IconIndex)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveItemFromThirdPartyPopupMenu(RegisterId, DocType, Item, IconIndex);
        }
        public static void PostMessageToApplication(ISldWorksObject ISldWorksinstance, Int32 Cookie, Int32 UserData)
        {
            ISldWorksinstance.ISldWorksInstance.PostMessageToApplication(Cookie, UserData);
        }
        public static Int32 GetCookiex64(ISldWorksObject ISldWorksinstance, String AddinClsid, Int64 ResourceModuleHandle, Object AddinCallbacks)
        {
            return ISldWorksinstance.ISldWorksInstance.GetCookiex64(AddinClsid, ResourceModuleHandle, AddinCallbacks);
        }
        //public static void GetRunningCommandInfo(ISldWorksObject ISldWorksinstance, Int32& CommandID, String& PMTitle, Boolean& IsUiActive)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetRunningCommandInfo(CommandID, PMTitle, IsUiActive);
        //}
        public static IRoutingSettingsObject GetRoutingSettings(ISldWorksObject ISldWorksinstance)
        {
            return new IRoutingSettingsObject(ISldWorksinstance.ISldWorksInstance.GetRoutingSettings());
        }
        //public static Boolean GetLineStyles(ISldWorksObject ISldWorksinstance, String StyleFile, Object& StyleNameList, Object& StyleList)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetLineStyles(StyleFile, StyleNameList, StyleList);
        //}
        public static Object GetRayTraceRenderer(ISldWorksObject ISldWorksinstance, Int32 RendererType)
        {
            return ISldWorksinstance.ISldWorksInstance.GetRayTraceRenderer(RendererType);
        }
        public static IRayTraceRendererObject IGetRayTraceRenderer(ISldWorksObject ISldWorksinstance, Int32 RendererType)
        {
            return new IRayTraceRendererObject(ISldWorksinstance.ISldWorksInstance.IGetRayTraceRenderer(RendererType));
        }
        public static Boolean RecordLineVBnet(ISldWorksObject ISldWorksinstance, String StringLine)
        {
            return ISldWorksinstance.ISldWorksInstance.RecordLineVBnet(StringLine);
        }
        public static Boolean RecordLineCSharp(ISldWorksObject ISldWorksinstance, String StringLine)
        {
            return ISldWorksinstance.ISldWorksInstance.RecordLineCSharp(StringLine);
        }
        public static Boolean AddItemToThirdPartyPopupMenu2(ISldWorksObject ISldWorksinstance, Int32 RegisterId, Int32 DocType, String Item, Int32 Identifier, String CallbackFunction, String EnableFunction, String CustomName, String HintString, String BitmapFileName, Int32 MenuItemTypeOption)
        {
            return ISldWorksinstance.ISldWorksInstance.AddItemToThirdPartyPopupMenu2(RegisterId, DocType, Item, Identifier, CallbackFunction, EnableFunction, CustomName, HintString, BitmapFileName, MenuItemTypeOption);
        }
        public static void PostMessageToApplicationx64(ISldWorksObject ISldWorksinstance, Int32 Cookie, Int64 UserData)
        {
            ISldWorksinstance.ISldWorksInstance.PostMessageToApplicationx64(Cookie, UserData);
        }
        public static Int32 AddMenuPopupItem4(ISldWorksObject ISldWorksinstance, Int32 DocumentType, Int32 Cookie, String SelectType, String PopupItemName, String MenuCallback, String MenuEnableMethod, String HintString, String CustomNames)
        {
            return ISldWorksinstance.ISldWorksInstance.AddMenuPopupItem4(DocumentType, Cookie, SelectType, PopupItemName, MenuCallback, MenuEnableMethod, HintString, CustomNames);
        }
        //public static void GetBuildNumbers2(ISldWorksObject ISldWorksinstance, String& BaseVersion, String& CurrentVersion, String& HotFixes)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetBuildNumbers2(BaseVersion, CurrentVersion, HotFixes);
        //}
        public static void SetPromptFilename2(ISldWorksObject ISldWorksinstance, String FileName, String ConfigName)
        {
            ISldWorksinstance.ISldWorksInstance.SetPromptFilename2(FileName, ConfigName);
        }
        //public static Int32 CloseAndReopen(ISldWorksObject ISldWorksinstance, ModelDoc2Object Doc, Int32 Option, ModelDoc2&Object NewDoc)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.CloseAndReopen(Doc, Option, NewDoc);
        //}
        //public static Object ActivateDoc3(ISldWorksObject ISldWorksinstance, String Name, Boolean UseUserPreferences, Int32 Option, Int32& Errors)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.ActivateDoc3(Name, UseUserPreferences, Option, Errors);
        //}
        public static Boolean CopyAppearance(ISldWorksObject ISldWorksinstance, Object Object)
        {
            return ISldWorksinstance.ISldWorksInstance.CopyAppearance(Object);
        }
        public static Boolean PasteAppearance(ISldWorksObject ISldWorksinstance, Object Object, Int32 AppearanceTarget)
        {
            return ISldWorksinstance.ISldWorksInstance.PasteAppearance(Object, AppearanceTarget);
        }
        public static Object GetSafeArrayUtility(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetSafeArrayUtility();
        }
        public static Boolean SetAddinCallbackInfo2(ISldWorksObject ISldWorksinstance, Int64 ModuleHandle, Object AddinCallbacks, Int32 Cookie)
        {
            return ISldWorksinstance.ISldWorksInstance.SetAddinCallbackInfo2(ModuleHandle, AddinCallbacks, Cookie);
        }
        //public static Boolean SanityCheck4(ISldWorksObject ISldWorksinstance, Int32 SwItemToCheck, Int32& P1, Int32& P2, Int64& P3)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.SanityCheck4(SwItemToCheck, P1, P2, P3);
        //}
        public static Int32 AddToolbar5(ISldWorksObject ISldWorksinstance, Int32 Cookie, String Title, Object ImageList, Int32 MenuPositionForToolbar, Int32 DocumentType)
        {
            return ISldWorksinstance.ISldWorksInstance.AddToolbar5(Cookie, Title, ImageList, MenuPositionForToolbar, DocumentType);
        }
        public static Int32 AddMenuItem5(ISldWorksObject ISldWorksinstance, Int32 DocumentType, Int32 Cookie, String MenuItem, Int32 Position, String MenuCallback, String MenuEnableMethod, String HintString, Object ImageList)
        {
            return ISldWorksinstance.ISldWorksInstance.AddMenuItem5(DocumentType, Cookie, MenuItem, Position, MenuCallback, MenuEnableMethod, HintString, ImageList);
        }
        //public static Int32 GetInterfaceBrightnessThemeColors(ISldWorksObject ISldWorksinstance, Object& Colors)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetInterfaceBrightnessThemeColors(Colors);
        //}
        public static Int32 GetCurrentLicenseType(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetCurrentLicenseType();
        }
        //public static Int32 GetImageSize(ISldWorksObject ISldWorksinstance, Int32& Small, Int32& Medium, Int32& Large)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetImageSize(Small, Medium, Large);
        //}
        public static ITaskpaneViewObject CreateTaskpaneView3(ISldWorksObject ISldWorksinstance, Object ImageList, String ToolTip)
        {
            return new ITaskpaneViewObject(ISldWorksinstance.ISldWorksInstance.CreateTaskpaneView3(ImageList, ToolTip));
        }
        public static Int32 SaveSettings(ISldWorksObject ISldWorksinstance, String FileName, Boolean SystemOptions, Int32 ToolbarLayout, Boolean KeyboardShortcuts, Boolean MouseGestures, Boolean MenuCustomization, Boolean SavedViews)
        {
            return ISldWorksinstance.ISldWorksInstance.SaveSettings(FileName, SystemOptions, ToolbarLayout, KeyboardShortcuts, MouseGestures, MenuCustomization, SavedViews);
        }
        public static Int32 RestoreSettings(ISldWorksObject ISldWorksinstance, String FileName, Boolean SystemOptions, Boolean ToolbarLayout, Boolean KeyboardShortcuts, Boolean MouseGestures, Boolean MenuCustomization, Boolean SavedViews, Boolean CreateBackup)
        {
            return ISldWorksinstance.ISldWorksInstance.RestoreSettings(FileName, SystemOptions, ToolbarLayout, KeyboardShortcuts, MouseGestures, MenuCustomization, SavedViews, CreateBackup);
        }
        public static Int32 ExportHoleWizardItem(ISldWorksObject ISldWorksinstance, String StdToExport, String DestinationFolderPath)
        {
            return ISldWorksinstance.ISldWorksInstance.ExportHoleWizardItem(StdToExport, DestinationFolderPath);
        }
        public static Int32 ImportHoleWizardItem(ISldWorksObject ISldWorksinstance, String StdToImport, String DestinationFilePath, Boolean ReplaceData, Boolean ErrorFile)
        {
            return ISldWorksinstance.ISldWorksInstance.ImportHoleWizardItem(StdToImport, DestinationFilePath, ReplaceData, ErrorFile);
        }
        public static Int32 ExportToolboxItem(ISldWorksObject ISldWorksinstance, String StdToExport, String DestinationFolderPath)
        {
            return ISldWorksinstance.ISldWorksInstance.ExportToolboxItem(StdToExport, DestinationFolderPath);
        }
        public static Int32 ImportToolboxItem(ISldWorksObject ISldWorksinstance, String StdToImport, String DestinationFilePath)
        {
            return ISldWorksinstance.ISldWorksInstance.ImportToolboxItem(StdToImport, DestinationFilePath);
        }
        //public static Boolean SanityCheck6(ISldWorksObject ISldWorksinstance, Int32 SwItemToCheck, Int32& P1, Int32& P2, Int64& P3, Int32& P4, Int32& P5)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.SanityCheck6(SwItemToCheck, P1, P2, P3, P4, P5);
        //}
        //public static Boolean SanityCheck5(ISldWorksObject ISldWorksinstance, Int32 SwItemToCheck, Int32& P1, Int32& P2, String& P3)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.SanityCheck5(SwItemToCheck, P1, P2, P3);
        //}
        public static Boolean AddFileOpenItem2(ISldWorksObject ISldWorksinstance, Int32 Cookie, String MethodName, String Description, String Extension)
        {
            return ISldWorksinstance.ISldWorksInstance.AddFileOpenItem2(Cookie, MethodName, Description, Extension);
        }
        public static Boolean RemoveFileOpenItem2(ISldWorksObject ISldWorksinstance, Int32 Cookie, String MethodName, String Description, String Extension)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveFileOpenItem2(Cookie, MethodName, Description, Extension);
        }
        public static Boolean AddFileSaveAsItem2(ISldWorksObject ISldWorksinstance, Int32 Cookie, String MethodName, String Description, String Extension, Int32 DocumentType)
        {
            return ISldWorksinstance.ISldWorksInstance.AddFileSaveAsItem2(Cookie, MethodName, Description, Extension, DocumentType);
        }
        public static Boolean RemoveFileSaveAsItem2(ISldWorksObject ISldWorksinstance, Int32 Cookie, String MethodName, String Description, String Extension, Int32 DocumentType)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveFileSaveAsItem2(Cookie, MethodName, Description, Extension, DocumentType);
        }
        public static Boolean AddMenuPopupItem2(ISldWorksObject ISldWorksinstance, Int32 DocumentType, Int32 Cookie, Int32 SelectType, String PopupItemName, String MenuCallback, String MenuEnableMethod, String HintString, String CustomNames)
        {
            return ISldWorksinstance.ISldWorksInstance.AddMenuPopupItem2(DocumentType, Cookie, SelectType, PopupItemName, MenuCallback, MenuEnableMethod, HintString, CustomNames);
        }
        public static Boolean RemoveMenuPopupItem2(ISldWorksObject ISldWorksinstance, Int32 DocumentType, Int32 Cookie, Int32 SelectType, String PopupItemName, String MenuCallback, String MenuEnableMethod, String HintString, String CustomNames)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveMenuPopupItem2(DocumentType, Cookie, SelectType, PopupItemName, MenuCallback, MenuEnableMethod, HintString, CustomNames);
        }
        public static Object GetMassProperties2(ISldWorksObject ISldWorksinstance, String FilePathName, String ConfigurationName, Int32 Accuracy)
        {
            return ISldWorksinstance.ISldWorksInstance.GetMassProperties2(FilePathName, ConfigurationName, Accuracy);
        }
        //public static Boolean IGetMassProperties2(ISldWorksObject ISldWorksinstance, String FilePathName, String ConfigurationName, Double& MPropsData, Int32 Accuracy)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.IGetMassProperties2(FilePathName, ConfigurationName, MPropsData, Accuracy);
        //}
        public static void HighlightTBButton(ISldWorksObject ISldWorksinstance, Int32 CmdID)
        {
            ISldWorksinstance.ISldWorksInstance.HighlightTBButton(CmdID);
        }
        public static Boolean RunMacro(ISldWorksObject ISldWorksinstance, String FilePathName, String ModuleName, String ProcedureName)
        {
            return ISldWorksinstance.ISldWorksInstance.RunMacro(FilePathName, ModuleName, ProcedureName);
        }
        public static Int32 GetConfigurationCount(ISldWorksObject ISldWorksinstance, String FilePathName)
        {
            return ISldWorksinstance.ISldWorksInstance.GetConfigurationCount(FilePathName);
        }
        public static Object GetConfigurationNames(ISldWorksObject ISldWorksinstance, String FilePathName)
        {
            return ISldWorksinstance.ISldWorksInstance.GetConfigurationNames(FilePathName);
        }
        public static String IGetConfigurationNames(ISldWorksObject ISldWorksinstance, String FilePathName, Int32 Count)
        {
            return ISldWorksinstance.ISldWorksInstance.IGetConfigurationNames(FilePathName, Count);
        }
        public static Object GetPreviewBitmap(ISldWorksObject ISldWorksinstance, String FilePathName, String ConfigName)
        {
            return ISldWorksinstance.ISldWorksInstance.GetPreviewBitmap(FilePathName, ConfigName);
        }
        public static String GetExecutablePath(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetExecutablePath();
        }
        public static Int32 GetEdition(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetEdition();
        }
        public static Int32 MoveDocument(ISldWorksObject ISldWorksinstance, String SourceDoc, String DestDoc, Object FromChildren, Object ToChildren, Int32 Option)
        {
            return ISldWorksinstance.ISldWorksInstance.MoveDocument(SourceDoc, DestDoc, FromChildren, ToChildren, Option);
        }
        public static Int32 CopyDocument(ISldWorksObject ISldWorksinstance, String SourceDoc, String DestDoc, Object FromChildren, Object ToChildren, Int32 Option)
        {
            return ISldWorksinstance.ISldWorksInstance.CopyDocument(SourceDoc, DestDoc, FromChildren, ToChildren, Option);
        }
        //public static Int32 IMoveDocument(ISldWorksObject ISldWorksinstance, String SourceDoc, String DestDoc, Int32 ChildCount, String& FromChildren, String& ToChildren, Int32 Option)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.IMoveDocument(SourceDoc, DestDoc, ChildCount, FromChildren, ToChildren, Option);
        //}
        //public static Int32 ICopyDocument(ISldWorksObject ISldWorksinstance, String SourceDoc, String DestDoc, Int32 ChildCount, String& FromChildren, String& ToChildren, Int32 Option)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.ICopyDocument(SourceDoc, DestDoc, ChildCount, FromChildren, ToChildren, Option);
        //}
        public static Int32 AddToolbar4(ISldWorksObject ISldWorksinstance, Int32 Cookie, String Title, String SmallBitmapImage, String LargeBitmapImage, Int32 MenuPositionForToolbar, Int32 DocumentType)
        {
            return ISldWorksinstance.ISldWorksInstance.AddToolbar4(Cookie, Title, SmallBitmapImage, LargeBitmapImage, MenuPositionForToolbar, DocumentType);
        }
        public static String GetActiveConfigurationName(ISldWorksObject ISldWorksinstance, String FilePathName)
        {
            return ISldWorksinstance.ISldWorksInstance.GetActiveConfigurationName(FilePathName);
        }
        public static Object Command(ISldWorksObject ISldWorksinstance, Int32 Command, Object Args)
        {
            return ISldWorksinstance.ISldWorksInstance.Command(Command, Args);
        }
        public static Object GetRecentFiles(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetRecentFiles();
        }
        public static void ShowBubbleTooltip(ISldWorksObject ISldWorksinstance, Int32 PointAt, String FlashButtonIDs, Int32 TitleResID, String TitleString, String MessageString)
        {
            ISldWorksinstance.ISldWorksInstance.ShowBubbleTooltip(PointAt, FlashButtonIDs, TitleResID, TitleString, MessageString);
        }
        public static String GetMaterialSchemaPathName(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetMaterialSchemaPathName();
        }
        public static Object GetMaterialDatabases(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetMaterialDatabases();
        }
        public static Int32 GetMaterialDatabaseCount(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetMaterialDatabaseCount();
        }
        public static String IGetMaterialDatabases(ISldWorksObject ISldWorksinstance, Int32 Count)
        {
            return ISldWorksinstance.ISldWorksInstance.IGetMaterialDatabases(Count);
        }
        //public static ITaskpaneViewObject CreateTaskpaneView(ISldWorksObject ISldWorksinstance, Int32& Bitmap, String ToolTip, Object PHandler)
        //{
        //    return new ITaskpaneViewObject(ISldWorksinstance.ISldWorksInstance.CreateTaskpaneView(Bitmap, ToolTip, PHandler));
        //}
        public static void ShowBubbleTooltipAt(ISldWorksObject ISldWorksinstance, Int32 PointX, Int32 PointY, Int32 ArrowPos, String TitleString, String MessageString, String UrlLoc)
        {
            ISldWorksinstance.ISldWorksInstance.ShowBubbleTooltipAt(PointX, PointY, ArrowPos, TitleString, MessageString, UrlLoc);
        }
        public static void InstallQuickTipGuide(ISldWorksObject ISldWorksinstance, Object PInterface)
        {
            ISldWorksinstance.ISldWorksInstance.InstallQuickTipGuide(PInterface);
        }
        public static void UnInstallQuickTipGuide(ISldWorksObject ISldWorksinstance, Object PInterface)
        {
            ISldWorksinstance.ISldWorksInstance.UnInstallQuickTipGuide(PInterface);
        }
        public static void RefreshQuickTipWindow(ISldWorksObject ISldWorksinstance)
        {
            ISldWorksinstance.ISldWorksInstance.RefreshQuickTipWindow();
        }
        public static Int32 GetLastToolbarID(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetLastToolbarID();
        }
        //public static IPtnrPMPageObject CreatePMPage(ISldWorksObject ISldWorksinstance, Int32 DialogId, String Title, Object Handler)
        //{
        //    return new IPtnrPMPageObject(ISldWorksinstance.ISldWorksInstance.CreatePMPage(DialogId, Title, Handler));
        //}
        public static Int32 GetUserTypeLibReferenceCount(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetUserTypeLibReferenceCount();
        }
        public static String IGetUserTypeLibReferences(ISldWorksObject ISldWorksinstance, Int32 NCount)
        {
            return ISldWorksinstance.ISldWorksInstance.IGetUserTypeLibReferences(NCount);
        }
        //public static void ISetUserTypeLibReferences(ISldWorksObject ISldWorksinstance, Int32 NCount, String& BstrTlbRef)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.ISetUserTypeLibReferences(NCount, BstrTlbRef);
        //}
        public static Boolean RemoveUserTypeLibReferences(ISldWorksObject ISldWorksinstance, Object VTlbRef)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveUserTypeLibReferences(VTlbRef);
        }
        //public static Boolean IRemoveUserTypeLibReferences(ISldWorksObject ISldWorksinstance, Int32 NCount, String& BstrTlbRef)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.IRemoveUserTypeLibReferences(NCount, BstrTlbRef);
        //}
        //public static String GetOpenFileName(ISldWorksObject ISldWorksinstance, String DialogTitle, String InitialFileName, String FileFilter, Int32& OpenOptions, String& ConfigName, String& DisplayName)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetOpenFileName(DialogTitle, InitialFileName, FileFilter, OpenOptions, ConfigName, DisplayName);
        //}
        public static void ShowTooltip(ISldWorksObject ISldWorksinstance, String ToolbarName, Int32 ButtonID, Int32 SelectIDMask1, Int32 SelectIDMask2, String TitleString, String MessageString)
        {
            ISldWorksinstance.ISldWorksInstance.ShowTooltip(ToolbarName, ButtonID, SelectIDMask1, SelectIDMask2, TitleString, MessageString);
        }
        public static Boolean AddMenuItem3(ISldWorksObject ISldWorksinstance, Int32 DocumentType, Int32 Cookie, String MenuItem, Int32 Position, String MenuCallback, String MenuEnableMethod, String HintString, String BitmapFilePath)
        {
            return ISldWorksinstance.ISldWorksInstance.AddMenuItem3(DocumentType, Cookie, MenuItem, Position, MenuCallback, MenuEnableMethod, HintString, BitmapFilePath);
        }
        public static Int32 GetLatestSupportedFileVersion(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetLatestSupportedFileVersion();
        }
        //public static void GetOpenedFileInfo(ISldWorksObject ISldWorksinstance, String& FileName, Int32& Options)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetOpenedFileInfo(FileName, Options);
        //}
        public static IModelDoc2Object GetOpenDocument(ISldWorksObject ISldWorksinstance, String DocName)
        {
            return new IModelDoc2Object(ISldWorksinstance.ISldWorksInstance.GetOpenDocument(DocName));
        }
        public static Object GetImportFileData(ISldWorksObject ISldWorksinstance, String FileName)
        {
            return ISldWorksinstance.ISldWorksInstance.GetImportFileData(FileName);
        }
        public static Boolean LoadFile3(ISldWorksObject ISldWorksinstance, String FileName, String ArgString, Object ImportData)
        {
            return ISldWorksinstance.ISldWorksInstance.LoadFile3(FileName, ArgString, ImportData);
        }
        public static ITaskpaneViewObject CreateTaskpaneView2(ISldWorksObject ISldWorksinstance, String Bitmap, String ToolTip)
        {
            return new ITaskpaneViewObject(ISldWorksinstance.ISldWorksInstance.CreateTaskpaneView2(Bitmap, ToolTip));
        }
        public static ICommandManagerObject GetCommandManager(ISldWorksObject ISldWorksinstance, Int32 Cookie)
        {
            return new ICommandManagerObject(ISldWorksinstance.ISldWorksInstance.GetCommandManager(Cookie));
        }
        public static void DragToolbarButton(ISldWorksObject ISldWorksinstance, Int32 SourceToolbar, Int32 TargetToolbar, Int32 SourceIndex, Int32 TargetIndex)
        {
            ISldWorksinstance.ISldWorksInstance.DragToolbarButton(SourceToolbar, TargetToolbar, SourceIndex, TargetIndex);
        }
        public static void AddCallback(ISldWorksObject ISldWorksinstance, Int32 Cookie, String CallbackFunction)
        {
            ISldWorksinstance.ISldWorksInstance.AddCallback(Cookie, CallbackFunction);
        }
        public static void RemoveCallback(ISldWorksObject ISldWorksinstance, Int32 Cookie)
        {
            ISldWorksinstance.ISldWorksInstance.RemoveCallback(Cookie);
        }
        public static void ShowHelp(ISldWorksObject ISldWorksinstance, String HelpFile, Int32 HelpTopic)
        {
            ISldWorksinstance.ISldWorksInstance.ShowHelp(HelpFile, HelpTopic);
        }
        //public static Int32 GetErrorMessages(ISldWorksObject ISldWorksinstance, Object& Msgs, Object& MsgIDs, Object& MsgTypes)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetErrorMessages(Msgs, MsgIDs, MsgTypes);
        //}
        public static String GetCurrentMacroPathFolder(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetCurrentMacroPathFolder();
        }
        //public static IModelDoc2Object LoadFile4(ISldWorksObject ISldWorksinstance, String FileName, String ArgString, Object ImportData, Int32& Errors)
        //{
        //    return new IModelDoc2Object(ISldWorksinstance.ISldWorksInstance.LoadFile4(FileName, ArgString, ImportData, Errors));
        //}
        public static Boolean CloseAllDocuments(ISldWorksObject ISldWorksinstance, Boolean IncludeUnsaved)
        {
            return ISldWorksinstance.ISldWorksInstance.CloseAllDocuments(IncludeUnsaved);
        }
        public static Int32 GetCommandID(ISldWorksObject ISldWorksinstance, String Clsid, Int32 UserCmdID)
        {
            return ISldWorksinstance.ISldWorksInstance.GetCommandID(Clsid, UserCmdID);
        }
        //public static Boolean PreviewDocx64(ISldWorksObject ISldWorksinstance, Int64& HWnd, String FullName)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.PreviewDocx64(HWnd, FullName);
        //}
        //public static Boolean GetUserProgressBar(ISldWorksObject ISldWorksinstance, UserProgressBar&Object PProgressBar)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetUserProgressBar(PProgressBar);
        //}
        public static Boolean AddFileOpenItem3(ISldWorksObject ISldWorksinstance, Int32 Cookie, String MethodName, String Description, String Extension, String OptionLabel, String OptionMethodName)
        {
            return ISldWorksinstance.ISldWorksInstance.AddFileOpenItem3(Cookie, MethodName, Description, Extension, OptionLabel, OptionMethodName);
        }
        public static Int32 GetCookie(ISldWorksObject ISldWorksinstance, String AddinClsid, Int32 ResourceModuleHandle, Object AddinCallbacks)
        {
            return ISldWorksinstance.ISldWorksInstance.GetCookie(AddinClsid, ResourceModuleHandle, AddinCallbacks);
        }
        public static Boolean ActivateTaskPane(ISldWorksObject ISldWorksinstance, Int32 TaskPaneID)
        {
            return ISldWorksinstance.ISldWorksInstance.ActivateTaskPane(TaskPaneID);
        }
        public static Object GetExportFileData(ISldWorksObject ISldWorksinstance, Int32 FileType)
        {
            return ISldWorksinstance.ISldWorksInstance.GetExportFileData(FileType);
        }
        public static Boolean RemoveFromMenu(ISldWorksObject ISldWorksinstance, Int32 CommandID, Int32 DocumentType, Int32 Option, Boolean RemoveParentMenu)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveFromMenu(CommandID, DocumentType, Option, RemoveParentMenu);
        }
        public static Boolean RemoveFromPopupMenu(ISldWorksObject ISldWorksinstance, Int32 CommandID, Int32 DocumentType, Int32 SelectionType, Boolean RemoveParentMenu)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveFromPopupMenu(CommandID, DocumentType, SelectionType, RemoveParentMenu);
        }
        //public static String GetMenuStrings(ISldWorksObject ISldWorksinstance, Int32 CommandID, Int32 DocumentType, String& ParentMenuName)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetMenuStrings(CommandID, DocumentType, ParentMenuName);
        //}
        public static void RefreshTaskpaneContent(ISldWorksObject ISldWorksinstance)
        {
            ISldWorksinstance.ISldWorksInstance.RefreshTaskpaneContent();
        }
        public static Boolean PresetNewDrawingParameters(ISldWorksObject ISldWorksinstance, String DrawingTemplate, Boolean ShowTemplate, Double Width, Double Height)
        {
            return ISldWorksinstance.ISldWorksInstance.PresetNewDrawingParameters(DrawingTemplate, ShowTemplate, Width, Height);
        }
        public static void ResetPresetDrawingParameters(ISldWorksObject ISldWorksinstance)
        {
            ISldWorksinstance.ISldWorksInstance.ResetPresetDrawingParameters();
        }
        public static Boolean GetDocumentVisible(ISldWorksObject ISldWorksinstance, Int32 Type)
        {
            return ISldWorksinstance.ISldWorksInstance.GetDocumentVisible(Type);
        }
        public static Boolean RunCommand(ISldWorksObject ISldWorksinstance, Int32 CommandID, String NewTitle)
        {
            return ISldWorksinstance.ISldWorksInstance.RunCommand(CommandID, NewTitle);
        }
        public static void HideBubbleTooltip(ISldWorksObject ISldWorksinstance)
        {
            ISldWorksinstance.ISldWorksInstance.HideBubbleTooltip();
        }
        public static Object GetOpenDocSpec(ISldWorksObject ISldWorksinstance, String FileName)
        {
            return ISldWorksinstance.ISldWorksInstance.GetOpenDocSpec(FileName);
        }
        public static Int32 IGetVersionHistoryCount(ISldWorksObject ISldWorksinstance, String FileName)
        {
            return ISldWorksinstance.ISldWorksInstance.IGetVersionHistoryCount(FileName);
        }
        public static Boolean AllowFailedFeatureCreation(ISldWorksObject ISldWorksinstance, Boolean YesNo)
        {
            return ISldWorksinstance.ISldWorksInstance.AllowFailedFeatureCreation(YesNo);
        }
        public static Object GetFirstDocument(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetFirstDocument();
        }
        public static String GetCurrentWorkingDirectory(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetCurrentWorkingDirectory();
        }
        public static Boolean SetCurrentWorkingDirectory(ISldWorksObject ISldWorksinstance, String CurrentWorkingDirectory)
        {
            return ISldWorksinstance.ISldWorksInstance.SetCurrentWorkingDirectory(CurrentWorkingDirectory);
        }
        public static String GetDataFolder(ISldWorksObject ISldWorksinstance, Boolean BShowErrorMsg)
        {
            return ISldWorksinstance.ISldWorksInstance.GetDataFolder(BShowErrorMsg);
        }
        public static Boolean GetSelectionFilter(ISldWorksObject ISldWorksinstance, Int32 SelType)
        {
            return ISldWorksinstance.ISldWorksInstance.GetSelectionFilter(SelType);
        }
        public static void SetSelectionFilter(ISldWorksObject ISldWorksinstance, Int32 SelType, Boolean State)
        {
            ISldWorksinstance.ISldWorksInstance.SetSelectionFilter(SelType, State);
        }
        //public static Object ActivateDoc2(ISldWorksObject ISldWorksinstance, String Name, Boolean Silent, Int32& Errors)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.ActivateDoc2(Name, Silent, Errors);
        //}
        //public static IModelDocObject IActivateDoc2(ISldWorksObject ISldWorksinstance, String Name, Boolean Silent, Int32& Errors)
        //{
        //    return new IModelDocObject(ISldWorksinstance.ISldWorksInstance.IActivateDoc2(Name, Silent, Errors));
        //}
        public static Boolean GetMouseDragMode(ISldWorksObject ISldWorksinstance, Int32 Command)
        {
            return ISldWorksinstance.ISldWorksInstance.GetMouseDragMode(Command);
        }
        public static String GetCurrentLanguage(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetCurrentLanguage();
        }
        public static IModelDocObject IGetFirstDocument(ISldWorksObject ISldWorksinstance)
        {
            return new IModelDocObject(ISldWorksinstance.ISldWorksInstance.IGetFirstDocument());
        }
        //public static Boolean SanityCheck(ISldWorksObject ISldWorksinstance, Int32 SwItemToCheck, Int32& P1, Int32& P2)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.SanityCheck(SwItemToCheck, P1, P2);
        //}
        public static Int32 AddMenu(ISldWorksObject ISldWorksinstance, Int32 DocType, String Menu, Int32 Position)
        {
            return ISldWorksinstance.ISldWorksInstance.AddMenu(DocType, Menu, Position);
        }
        public static Int32 CheckpointConvertedDocument(ISldWorksObject ISldWorksinstance, String DocName)
        {
            return ISldWorksinstance.ISldWorksInstance.CheckpointConvertedDocument(DocName);
        }
        //public static Object OpenDoc2(ISldWorksObject ISldWorksinstance, String FileName, Int32 Type, Boolean ReadOnly, Boolean ViewOnly, Boolean Silent, Int32& Errors)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.OpenDoc2(FileName, Type, ReadOnly, ViewOnly, Silent, Errors);
        //}
        //public static IModelDocObject IOpenDoc2(ISldWorksObject ISldWorksinstance, String FileName, Int32 Type, Boolean ReadOnly, Boolean ViewOnly, Boolean Silent, Int32& Errors)
        //{
        //    return new IModelDocObject(ISldWorksinstance.ISldWorksInstance.IOpenDoc2(FileName, Type, ReadOnly, ViewOnly, Silent, Errors));
        //}
        public static Object GetMassProperties(ISldWorksObject ISldWorksinstance, String FilePathName, String ConfigurationName)
        {
            return ISldWorksinstance.ISldWorksInstance.GetMassProperties(FilePathName, ConfigurationName);
        }
        //public static Boolean IGetMassProperties(ISldWorksObject ISldWorksinstance, String FilePathName, String ConfigurationName, Double& MPropsData)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.IGetMassProperties(FilePathName, ConfigurationName, MPropsData);
        //}
        public static String GetLocalizedMenuName(ISldWorksObject ISldWorksinstance, Int32 MenuId)
        {
            return ISldWorksinstance.ISldWorksInstance.GetLocalizedMenuName(MenuId);
        }
        public static Object GetDocumentDependencies2(ISldWorksObject ISldWorksinstance, String Document, Boolean Traverseflag, Boolean Searchflag, Boolean AddReadOnlyInfo)
        {
            return ISldWorksinstance.ISldWorksInstance.GetDocumentDependencies2(Document, Traverseflag, Searchflag, AddReadOnlyInfo);
        }
        public static String IGetDocumentDependencies2(ISldWorksObject ISldWorksinstance, String Document, Boolean Traverseflag, Boolean Searchflag, Boolean AddReadOnlyInfo)
        {
            return ISldWorksinstance.ISldWorksInstance.IGetDocumentDependencies2(Document, Traverseflag, Searchflag, AddReadOnlyInfo);
        }
        public static Int32 IGetDocumentDependenciesCount2(ISldWorksObject ISldWorksinstance, String Document, Boolean Traverseflag, Boolean Searchflag, Boolean AddReadOnlyInfo)
        {
            return ISldWorksinstance.ISldWorksInstance.IGetDocumentDependenciesCount2(Document, Traverseflag, Searchflag, AddReadOnlyInfo);
        }
        public static Object GetSelectionFilters(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetSelectionFilters();
        }
        public static void SetSelectionFilters(ISldWorksObject ISldWorksinstance, Object SelType, Boolean State)
        {
            ISldWorksinstance.ISldWorksInstance.SetSelectionFilters(SelType, State);
        }
        public static Boolean GetApplySelectionFilter(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetApplySelectionFilter();
        }
        public static void SetApplySelectionFilter(ISldWorksObject ISldWorksinstance, Boolean State)
        {
            ISldWorksinstance.ISldWorksInstance.SetApplySelectionFilter(State);
        }
        public static Object NewDocument(ISldWorksObject ISldWorksinstance, String TemplateName, Int32 PaperSize, Double Width, Double Height)
        {
            return ISldWorksinstance.ISldWorksInstance.NewDocument(TemplateName, PaperSize, Width, Height);
        }
        public static IModelDocObject INewDocument(ISldWorksObject ISldWorksinstance, String TemplateName, Int32 PaperSize, Double Width, Double Height)
        {
            return new IModelDocObject(ISldWorksinstance.ISldWorksInstance.INewDocument(TemplateName, PaperSize, Width, Height));
        }
        public static String GetDocumentTemplate(ISldWorksObject ISldWorksinstance, Int32 Mode, String TemplateName, Int32 PaperSize, Double Width, Double Height)
        {
            return ISldWorksinstance.ISldWorksInstance.GetDocumentTemplate(Mode, TemplateName, PaperSize, Width, Height);
        }
        public static Int32 IGetSelectionFiltersCount(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.IGetSelectionFiltersCount();
        }
        public static Int32 IGetSelectionFilters(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.IGetSelectionFilters();
        }
        //public static void ISetSelectionFilters(ISldWorksObject ISldWorksinstance, Int32 Count, Int32& SelType, Boolean State)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.ISetSelectionFilters(Count, SelType, State);
        //}
        public static String GetCurrSolidWorksRegSubKey(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetCurrSolidWorksRegSubKey();
        }
        public static void SolidWorksExplorer(ISldWorksObject ISldWorksinstance)
        {
            ISldWorksinstance.ISldWorksInstance.SolidWorksExplorer();
        }
        public static String GetUserPreferenceStringValue(ISldWorksObject ISldWorksinstance, Int32 UserPreference)
        {
            return ISldWorksinstance.ISldWorksInstance.GetUserPreferenceStringValue(UserPreference);
        }
        public static Boolean SetUserPreferenceStringValue(ISldWorksObject ISldWorksinstance, Int32 UserPreference, String Value)
        {
            return ISldWorksinstance.ISldWorksInstance.SetUserPreferenceStringValue(UserPreference, Value);
        }
        public static String GetCurrentMacroPathName(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetCurrentMacroPathName();
        }
        public static Object GetOpenDocumentByName(ISldWorksObject ISldWorksinstance, String DocumentName)
        {
            return ISldWorksinstance.ISldWorksInstance.GetOpenDocumentByName(DocumentName);
        }
        public static IModelDocObject IGetOpenDocumentByName(ISldWorksObject ISldWorksinstance, String DocumentName)
        {
            return new IModelDocObject(ISldWorksinstance.ISldWorksInstance.IGetOpenDocumentByName(DocumentName));
        }
        //public static void GetCurrentKernelVersions(ISldWorksObject ISldWorksinstance, String& Version1, String& Version2, String& Version3)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.GetCurrentKernelVersions(Version1, Version2, Version3);
        //}
        public static String CreatePrunedModelArchive(ISldWorksObject ISldWorksinstance, String PathName, String ZipPathName)
        {
            return ISldWorksinstance.ISldWorksInstance.CreatePrunedModelArchive(PathName, ZipPathName);
        }
        //public static Object OpenDoc3(ISldWorksObject ISldWorksinstance, String FileName, Int32 Type, Boolean ReadOnly, Boolean ViewOnly, Boolean RapidDraft, Boolean Silent, Int32& Errors)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.OpenDoc3(FileName, Type, ReadOnly, ViewOnly, RapidDraft, Silent, Errors);
        //}
        //public static IModelDocObject IOpenDoc3(ISldWorksObject ISldWorksinstance, String FileName, Int32 Type, Boolean ReadOnly, Boolean ViewOnly, Boolean RapidDraft, Boolean Silent, Int32& Errors)
        //{
        //    return new IModelDocObject(ISldWorksinstance.ISldWorksInstance.IOpenDoc3(FileName, Type, ReadOnly, ViewOnly, RapidDraft, Silent, Errors));
        //}
        public static Int32 AddToolbar2(ISldWorksObject ISldWorksinstance, String ModuleNameIn, String TitleIn, Int32 SmallBitmapHandleIn, Int32 LargeBitmapHandleIn, Int32 MenuPosIn, Int32 DecTemplateTypeIn)
        {
            return ISldWorksinstance.ISldWorksInstance.AddToolbar2(ModuleNameIn, TitleIn, SmallBitmapHandleIn, LargeBitmapHandleIn, MenuPosIn, DecTemplateTypeIn);
        }
        public static Object OpenModelConfiguration(ISldWorksObject ISldWorksinstance, String PathName, String ConfigName)
        {
            return ISldWorksinstance.ISldWorksInstance.OpenModelConfiguration(PathName, ConfigName);
        }
        public static Int32 GetToolbarDock(ISldWorksObject ISldWorksinstance, String ModuleIn, Int32 ToolbarIDIn)
        {
            return ISldWorksinstance.ISldWorksInstance.GetToolbarDock(ModuleIn, ToolbarIDIn);
        }
        public static void SetToolbarDock(ISldWorksObject ISldWorksinstance, String ModuleIn, Int32 ToolbarIDIn, Int32 DocStatePosIn)
        {
            ISldWorksinstance.ISldWorksInstance.SetToolbarDock(ModuleIn, ToolbarIDIn, DocStatePosIn);
        }
        public static Object GetMathUtility(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetMathUtility();
        }
        public static IMathUtilityObject IGetMathUtility(ISldWorksObject ISldWorksinstance)
        {
            return new IMathUtilityObject(ISldWorksinstance.ISldWorksInstance.IGetMathUtility());
        }
        //public static Object OpenDoc4(ISldWorksObject ISldWorksinstance, String FileName, Int32 Type, Int32 Options, String Configuration, Int32& Errors)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.OpenDoc4(FileName, Type, Options, Configuration, Errors);
        //}
        //public static IModelDocObject IOpenDoc4(ISldWorksObject ISldWorksinstance, String FileName, Int32 Type, Int32 Options, String Configuration, Int32& Errors)
        //{
        //    return new IModelDocObject(ISldWorksinstance.ISldWorksInstance.IOpenDoc4(FileName, Type, Options, Configuration, Errors));
        //}
        public static Boolean IsRapidDraft(ISldWorksObject ISldWorksinstance, String FileName)
        {
            return ISldWorksinstance.ISldWorksInstance.IsRapidDraft(FileName);
        }
        public static Object GetTemplateSizes(ISldWorksObject ISldWorksinstance, String FileName)
        {
            return ISldWorksinstance.ISldWorksInstance.GetTemplateSizes(FileName);
        }
        //public static Boolean IGetTemplateSizes(ISldWorksObject ISldWorksinstance, String FileName, Int32& PaperSize, Double& Width, Double& Height)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.IGetTemplateSizes(FileName, PaperSize, Width, Height);
        //}
        public static Object GetColorTable(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetColorTable();
        }
        public static IColorTableObject IGetColorTable(ISldWorksObject ISldWorksinstance)
        {
            return new IColorTableObject(ISldWorksinstance.ISldWorksInstance.IGetColorTable());
        }
        public static void SetMissingReferencePathName(ISldWorksObject ISldWorksinstance, String FileName)
        {
            ISldWorksinstance.ISldWorksInstance.SetMissingReferencePathName(FileName);
        }
        public static Object GetUserUnit(ISldWorksObject ISldWorksinstance, Int32 UnitType)
        {
            return ISldWorksinstance.ISldWorksInstance.GetUserUnit(UnitType);
        }
        public static IUserUnitObject IGetUserUnit(ISldWorksObject ISldWorksinstance, Int32 UnitType)
        {
            return new IUserUnitObject(ISldWorksinstance.ISldWorksInstance.IGetUserUnit(UnitType));
        }
        public static Boolean SetMouseDragMode(ISldWorksObject ISldWorksinstance, Int32 Command)
        {
            return ISldWorksinstance.ISldWorksInstance.SetMouseDragMode(Command);
        }
        public static void SetPromptFilename(ISldWorksObject ISldWorksinstance, String FileName)
        {
            ISldWorksinstance.ISldWorksInstance.SetPromptFilename(FileName);
        }
        public static Boolean SetAddinCallbackInfo(ISldWorksObject ISldWorksinstance, Int32 ModuleHandle, Object AddinCallbacks, Int32 Cookie)
        {
            return ISldWorksinstance.ISldWorksInstance.SetAddinCallbackInfo(ModuleHandle, AddinCallbacks, Cookie);
        }
        public static Boolean AddMenuItem2(ISldWorksObject ISldWorksinstance, Int32 DocumentType, Int32 Cookie, String MenuItem, Int32 Position, String MenuCallback, String MenuEnableMethod, String HintString)
        {
            return ISldWorksinstance.ISldWorksInstance.AddMenuItem2(DocumentType, Cookie, MenuItem, Position, MenuCallback, MenuEnableMethod, HintString);
        }
        public static Int32 AddToolbar3(ISldWorksObject ISldWorksinstance, Int32 Cookie, String Title, Int32 SmallBitmapResourceID, Int32 LargeBitmapResourceID, Int32 MenuPositionForToolbar, Int32 DocumentType)
        {
            return ISldWorksinstance.ISldWorksInstance.AddToolbar3(Cookie, Title, SmallBitmapResourceID, LargeBitmapResourceID, MenuPositionForToolbar, DocumentType);
        }
        public static Boolean RemoveToolbar2(ISldWorksObject ISldWorksinstance, Int32 Cookie, Int32 ToolbarId)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveToolbar2(Cookie, ToolbarId);
        }
        public static Boolean AddToolbarCommand2(ISldWorksObject ISldWorksinstance, Int32 Cookie, Int32 ToolbarId, Int32 ToolbarIndex, String ButtonCallback, String ButtonEnableMethod, String ToolTip, String HintString)
        {
            return ISldWorksinstance.ISldWorksInstance.AddToolbarCommand2(Cookie, ToolbarId, ToolbarIndex, ButtonCallback, ButtonEnableMethod, ToolTip, HintString);
        }
        public static Boolean ShowToolbar2(ISldWorksObject ISldWorksinstance, Int32 Cookie, Int32 ToolbarId)
        {
            return ISldWorksinstance.ISldWorksInstance.ShowToolbar2(Cookie, ToolbarId);
        }
        public static Boolean HideToolbar2(ISldWorksObject ISldWorksinstance, Int32 Cookie, Int32 ToolbarId)
        {
            return ISldWorksinstance.ISldWorksInstance.HideToolbar2(Cookie, ToolbarId);
        }
        public static Boolean GetToolbarState2(ISldWorksObject ISldWorksinstance, Int32 Cookie, Int32 ToolbarId, Int32 ToolbarState)
        {
            return ISldWorksinstance.ISldWorksInstance.GetToolbarState2(Cookie, ToolbarId, ToolbarState);
        }
        public static Int32 GetToolbarDock2(ISldWorksObject ISldWorksinstance, Int32 Cookie, Int32 ToolbarId)
        {
            return ISldWorksinstance.ISldWorksInstance.GetToolbarDock2(Cookie, ToolbarId);
        }
        public static Boolean SetToolbarDock2(ISldWorksObject ISldWorksinstance, Int32 Cookie, Int32 ToolbarId, Int32 DockingState)
        {
            return ISldWorksinstance.ISldWorksInstance.SetToolbarDock2(Cookie, ToolbarId, DockingState);
        }
        //public static IModelDoc2Object IActivateDoc3(ISldWorksObject ISldWorksinstance, String Name, Boolean Silent, Int32& Errors)
        //{
        //    return new IModelDoc2Object(ISldWorksinstance.ISldWorksInstance.IActivateDoc3(Name, Silent, Errors));
        //}
        public static IModelDoc2Object IGetFirstDocument2(ISldWorksObject ISldWorksinstance)
        {
            return new IModelDoc2Object(ISldWorksinstance.ISldWorksInstance.IGetFirstDocument2());
        }
        public static IModelDoc2Object INewDocument2(ISldWorksObject ISldWorksinstance, String TemplateName, Int32 PaperSize, Double Width, Double Height)
        {
            return new IModelDoc2Object(ISldWorksinstance.ISldWorksInstance.INewDocument2(TemplateName, PaperSize, Width, Height));
        }
        public static IModelDoc2Object IGetOpenDocumentByName2(ISldWorksObject ISldWorksinstance, String DocumentName)
        {
            return new IModelDoc2Object(ISldWorksinstance.ISldWorksInstance.IGetOpenDocumentByName2(DocumentName));
        }
        //public static IModelDoc2Object IOpenDoc5(ISldWorksObject ISldWorksinstance, String FileName, Int32 Type, Int32 Options, String Configuration, Int32& Errors)
        //{
        //    return new IModelDoc2Object(ISldWorksinstance.ISldWorksInstance.IOpenDoc5(FileName, Type, Options, Configuration, Errors));
        //}
        //public static IEnumDocuments2Object EnumDocuments2(ISldWorksObject ISldWorksinstance)
        //{
        //    return new IEnumDocuments2Object(ISldWorksinstance.ISldWorksInstance.EnumDocuments2());
        //}
        //public static Object CreatePropertyManagerPage(ISldWorksObject ISldWorksinstance, String Title, Int32 Options, Object Handler, Int32& Errors)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.CreatePropertyManagerPage(Title, Options, Handler, Errors);
        //}
        //public static IPropertyManagerPage2Object ICreatePropertyManagerPage(ISldWorksObject ISldWorksinstance, String Title, Int32 Options, Object Handler, Int32& Errors)
        //{
        //    return new IPropertyManagerPage2Object(ISldWorksinstance.ISldWorksInstance.ICreatePropertyManagerPage(Title, Options, Handler, Errors));
        //}
        public static Object GetAddInObject(ISldWorksObject ISldWorksinstance, String Clsid)
        {
            return ISldWorksinstance.ISldWorksInstance.GetAddInObject(Clsid);
        }
        public static Int32 GetProcessID(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetProcessID();
        }
        //public static IModelDoc2Object OpenDoc6(ISldWorksObject ISldWorksinstance, String FileName, Int32 Type, Int32 Options, String Configuration, Int32& Errors, Int32& Warnings)
        //{
        //    return new IModelDoc2Object(ISldWorksinstance.ISldWorksInstance.OpenDoc6(FileName, Type, Options, Configuration, Errors, Warnings));
        //}
        public static Object OpenDoc(ISldWorksObject ISldWorksinstance, String Name, Int32 Type)
        {
            return ISldWorksinstance.ISldWorksInstance.OpenDoc(Name, Type);
        }
        public static IModelDocObject IOpenDoc(ISldWorksObject ISldWorksinstance, String Name, Int32 Type)
        {
            return new IModelDocObject(ISldWorksinstance.ISldWorksInstance.IOpenDoc(Name, Type));
        }
        public static Object ActivateDoc(ISldWorksObject ISldWorksinstance, String Name)
        {
            return ISldWorksinstance.ISldWorksInstance.ActivateDoc(Name);
        }
        public static IModelDocObject IActivateDoc(ISldWorksObject ISldWorksinstance, String Name)
        {
            return new IModelDocObject(ISldWorksinstance.ISldWorksInstance.IActivateDoc(Name));
        }
        public static void SendMsgToUser(ISldWorksObject ISldWorksinstance, String Message)
        {
            ISldWorksinstance.ISldWorksInstance.SendMsgToUser(Message);
        }
        public static Object Frame(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.Frame();
        }
        public static IFrameObject IFrameObject(ISldWorksObject ISldWorksinstance)
        {
            return new IFrameObject(ISldWorksinstance.ISldWorksInstance.IFrameObject());
        }
        public static void ExitApp(ISldWorksObject ISldWorksinstance)
        {
            ISldWorksinstance.ISldWorksInstance.ExitApp();
        }
        public static void CloseDoc(ISldWorksObject ISldWorksinstance, String Name)
        {
            ISldWorksinstance.ISldWorksInstance.CloseDoc(Name);
        }
        public static Object NewPart(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.NewPart();
        }
        public static IPartDocObject INewPart(ISldWorksObject ISldWorksinstance)
        {
            return new IPartDocObject(ISldWorksinstance.ISldWorksInstance.INewPart());
        }
        public static Object NewAssembly(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.NewAssembly();
        }
        public static IAssemblyDocObject INewAssembly(ISldWorksObject ISldWorksinstance)
        {
            return new IAssemblyDocObject(ISldWorksinstance.ISldWorksInstance.INewAssembly());
        }
        public static Object NewDrawing(ISldWorksObject ISldWorksinstance, Int32 TemplateToUse)
        {
            return ISldWorksinstance.ISldWorksInstance.NewDrawing(TemplateToUse);
        }
        public static IDrawingDocObject INewDrawing(ISldWorksObject ISldWorksinstance, Int32 TemplateToUse)
        {
            return new IDrawingDocObject(ISldWorksinstance.ISldWorksInstance.INewDrawing(TemplateToUse));
        }
        public static Int32 DateCode(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.DateCode();
        }
        public static String RevisionNumber(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.RevisionNumber();
        }
        public static Boolean LoadFile(ISldWorksObject ISldWorksinstance, String FileName)
        {
            return ISldWorksinstance.ISldWorksInstance.LoadFile(FileName);
        }
        public static Boolean AddFileOpenItem(ISldWorksObject ISldWorksinstance, String CallbackFcnAndModule, String Description)
        {
            return ISldWorksinstance.ISldWorksInstance.AddFileOpenItem(CallbackFcnAndModule, Description);
        }
        public static Boolean AddFileSaveAsItem(ISldWorksObject ISldWorksinstance, String CallbackFcnAndModule, String Description, Int32 Type)
        {
            return ISldWorksinstance.ISldWorksInstance.AddFileSaveAsItem(CallbackFcnAndModule, Description, Type);
        }
        public static void PreSelectDwgTemplateSize(ISldWorksObject ISldWorksinstance, Int32 TemplateToUse, String TemplateName)
        {
            ISldWorksinstance.ISldWorksInstance.PreSelectDwgTemplateSize(TemplateToUse, TemplateName);
        }
        public static void DocumentVisible(ISldWorksObject ISldWorksinstance, Boolean Visible, Int32 Type)
        {
            ISldWorksinstance.ISldWorksInstance.DocumentVisible(Visible, Type);
        }
        public static Object DefineAttribute(ISldWorksObject ISldWorksinstance, String Name)
        {
            return ISldWorksinstance.ISldWorksInstance.DefineAttribute(Name);
        }
        public static IAttributeDefObject IDefineAttribute(ISldWorksObject ISldWorksinstance, String Name)
        {
            return new IAttributeDefObject(ISldWorksinstance.ISldWorksInstance.IDefineAttribute(Name));
        }
        public static void DisplayStatusBar(ISldWorksObject ISldWorksinstance, Boolean OnOff)
        {
            ISldWorksinstance.ISldWorksInstance.DisplayStatusBar(OnOff);
        }
        public static void CreateNewWindow(ISldWorksObject ISldWorksinstance)
        {
            ISldWorksinstance.ISldWorksInstance.CreateNewWindow();
        }
        public static void ArrangeIcons(ISldWorksObject ISldWorksinstance)
        {
            ISldWorksinstance.ISldWorksInstance.ArrangeIcons();
        }
        public static void ArrangeWindows(ISldWorksObject ISldWorksinstance, Int32 Style)
        {
            ISldWorksinstance.ISldWorksInstance.ArrangeWindows(Style);
        }
        public static void QuitDoc(ISldWorksObject ISldWorksinstance, String Name)
        {
            ISldWorksinstance.ISldWorksInstance.QuitDoc(Name);
        }
        public static Object GetModeler(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetModeler();
        }
        public static IModelerObject IGetModeler(ISldWorksObject ISldWorksinstance)
        {
            return new IModelerObject(ISldWorksinstance.ISldWorksInstance.IGetModeler());
        }
        public static Object GetEnvironment(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.GetEnvironment();
        }
        //public static IEnvironmentObject IGetEnvironment(ISldWorksObject ISldWorksinstance)
        //{
        //    return new IEnvironmentObject(ISldWorksinstance.ISldWorksInstance.IGetEnvironment());
        //}
        public static Object NewDrawing2(ISldWorksObject ISldWorksinstance, Int32 TemplateToUse, String TemplateName, Int32 PaperSize, Double Width, Double Height)
        {
            return ISldWorksinstance.ISldWorksInstance.NewDrawing2(TemplateToUse, TemplateName, PaperSize, Width, Height);
        }
        public static IDrawingDocObject INewDrawing2(ISldWorksObject ISldWorksinstance, Int32 TemplateToUse, String TemplateName, Int32 PaperSize, Double Width, Double Height)
        {
            return new IDrawingDocObject(ISldWorksinstance.ISldWorksInstance.INewDrawing2(TemplateToUse, TemplateName, PaperSize, Width, Height));
        }
        public static Boolean SetOptions(ISldWorksObject ISldWorksinstance, String Message)
        {
            return ISldWorksinstance.ISldWorksInstance.SetOptions(Message);
        }
        //public static Boolean PreviewDoc(ISldWorksObject ISldWorksinstance, Int32& HWnd, String FullName)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.PreviewDoc(HWnd, FullName);
        //}
        public static String GetSearchFolders(ISldWorksObject ISldWorksinstance, Int32 FolderType)
        {
            return ISldWorksinstance.ISldWorksInstance.GetSearchFolders(FolderType);
        }
        public static Boolean SetSearchFolders(ISldWorksObject ISldWorksinstance, Int32 FolderType, String Folders)
        {
            return ISldWorksinstance.ISldWorksInstance.SetSearchFolders(FolderType, Folders);
        }
        public static Boolean GetUserPreferenceToggle(ISldWorksObject ISldWorksinstance, Int32 UserPreferenceToggle)
        {
            return ISldWorksinstance.ISldWorksInstance.GetUserPreferenceToggle(UserPreferenceToggle);
        }
        public static void SetUserPreferenceToggle(ISldWorksObject ISldWorksinstance, Int32 UserPreferenceValue, Boolean OnFlag)
        {
            ISldWorksinstance.ISldWorksInstance.SetUserPreferenceToggle(UserPreferenceValue, OnFlag);
        }
        public static Double GetUserPreferenceDoubleValue(ISldWorksObject ISldWorksinstance, Int32 UserPreferenceValue)
        {
            return ISldWorksinstance.ISldWorksInstance.GetUserPreferenceDoubleValue(UserPreferenceValue);
        }
        public static Boolean SetUserPreferenceDoubleValue(ISldWorksObject ISldWorksinstance, Int32 UserPreferenceValue, Double Value)
        {
            return ISldWorksinstance.ISldWorksInstance.SetUserPreferenceDoubleValue(UserPreferenceValue, Value);
        }
        public static Boolean LoadFile2(ISldWorksObject ISldWorksinstance, String FileName, String ArgString)
        {
            return ISldWorksinstance.ISldWorksInstance.LoadFile2(FileName, ArgString);
        }
        public static Int32 GetUserPreferenceIntegerValue(ISldWorksObject ISldWorksinstance, Int32 UserPreferenceValue)
        {
            return ISldWorksinstance.ISldWorksInstance.GetUserPreferenceIntegerValue(UserPreferenceValue);
        }
        public static Boolean SetUserPreferenceIntegerValue(ISldWorksObject ISldWorksinstance, Int32 UserPreferenceValue, Int32 Value)
        {
            return ISldWorksinstance.ISldWorksInstance.SetUserPreferenceIntegerValue(UserPreferenceValue, Value);
        }
        public static Boolean RemoveMenuPopupItem(ISldWorksObject ISldWorksinstance, Int32 DocType, Int32 SelectType, String Item, String CallbackFcnAndModule, String CustomNames, Int32 Unused)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveMenuPopupItem(DocType, SelectType, Item, CallbackFcnAndModule, CustomNames, Unused);
        }
        public static Boolean RemoveMenu(ISldWorksObject ISldWorksinstance, Int32 DocType, String MenuItemString, String CallbackFcnAndModule)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveMenu(DocType, MenuItemString, CallbackFcnAndModule);
        }
        public static Boolean RemoveFileOpenItem(ISldWorksObject ISldWorksinstance, String CallbackFcnAndModule, String Description)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveFileOpenItem(CallbackFcnAndModule, Description);
        }
        public static Boolean RemoveFileSaveAsItem(ISldWorksObject ISldWorksinstance, String CallbackFcnAndModule, String Description, Int32 Type)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveFileSaveAsItem(CallbackFcnAndModule, Description, Type);
        }
        public static Boolean ReplaceReferencedDocument(ISldWorksObject ISldWorksinstance, String ReferencingDocument, String ReferencedDocument, String NewReference)
        {
            return ISldWorksinstance.ISldWorksInstance.ReplaceReferencedDocument(ReferencingDocument, ReferencedDocument, NewReference);
        }
        public static Int32 AddMenuItem(ISldWorksObject ISldWorksinstance, Int32 DocType, String Menu, Int32 Postion, String CallbackModuleAndFcn)
        {
            return ISldWorksinstance.ISldWorksInstance.AddMenuItem(DocType, Menu, Postion, CallbackModuleAndFcn);
        }
        public static Int32 AddMenuPopupItem(ISldWorksObject ISldWorksinstance, Int32 DocType, Int32 SelType, String Item, String CallbackFcnAndModule, String CustomNames)
        {
            return ISldWorksinstance.ISldWorksInstance.AddMenuPopupItem(DocType, SelType, Item, CallbackFcnAndModule, CustomNames);
        }
        public static Boolean RemoveUserMenu(ISldWorksObject ISldWorksinstance, Int32 DocType, Int32 MenuIdIn, String ModuleName)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveUserMenu(DocType, MenuIdIn, ModuleName);
        }
        public static Int32 AddToolbar(ISldWorksObject ISldWorksinstance, String ModuleName, String Title, Int32 SmallBitmapHandle, Int32 LargeBitmapHandle)
        {
            return ISldWorksinstance.ISldWorksInstance.AddToolbar(ModuleName, Title, SmallBitmapHandle, LargeBitmapHandle);
        }
        public static Boolean AddToolbarCommand(ISldWorksObject ISldWorksinstance, String ModuleName, Int32 ToolbarId, Int32 ToolbarIndex, String CommandString)
        {
            return ISldWorksinstance.ISldWorksInstance.AddToolbarCommand(ModuleName, ToolbarId, ToolbarIndex, CommandString);
        }
        public static Boolean ShowToolbar(ISldWorksObject ISldWorksinstance, String ModuleName, Int32 ToolbarId)
        {
            return ISldWorksinstance.ISldWorksInstance.ShowToolbar(ModuleName, ToolbarId);
        }
        public static Boolean HideToolbar(ISldWorksObject ISldWorksinstance, String ModuleName, Int32 ToolbarId)
        {
            return ISldWorksinstance.ISldWorksInstance.HideToolbar(ModuleName, ToolbarId);
        }
        public static Boolean RemoveToolbar(ISldWorksObject ISldWorksinstance, String Module, Int32 ToolbarId)
        {
            return ISldWorksinstance.ISldWorksInstance.RemoveToolbar(Module, ToolbarId);
        }
        public static Boolean GetToolbarState(ISldWorksObject ISldWorksinstance, String Module, Int32 ToolbarId, Int32 ToolbarState)
        {
            return ISldWorksinstance.ISldWorksInstance.GetToolbarState(Module, ToolbarId, ToolbarState);
        }
        public static String GetUserPreferenceStringListValue(ISldWorksObject ISldWorksinstance, Int32 UserPreference)
        {
            return ISldWorksinstance.ISldWorksInstance.GetUserPreferenceStringListValue(UserPreference);
        }
        public static void SetUserPreferenceStringListValue(ISldWorksObject ISldWorksinstance, Int32 UserPreference, String Value)
        {
            ISldWorksinstance.ISldWorksInstance.SetUserPreferenceStringListValue(UserPreference, Value);
        }
        public static Boolean EnableStereoDisplay(ISldWorksObject ISldWorksinstance, Boolean BEnable)
        {
            return ISldWorksinstance.ISldWorksInstance.EnableStereoDisplay(BEnable);
        }
        public static Boolean IEnableStereoDisplay(ISldWorksObject ISldWorksinstance, Boolean BEnable)
        {
            return ISldWorksinstance.ISldWorksInstance.IEnableStereoDisplay(BEnable);
        }
        public static Object GetDocumentDependencies(ISldWorksObject ISldWorksinstance, String Document, Int32 Traverseflag, Int32 Searchflag)
        {
            return ISldWorksinstance.ISldWorksInstance.GetDocumentDependencies(Document, Traverseflag, Searchflag);
        }
        public static String IGetDocumentDependencies(ISldWorksObject ISldWorksinstance, String Document, Int32 Traverseflag, Int32 Searchflag)
        {
            return ISldWorksinstance.ISldWorksInstance.IGetDocumentDependencies(Document, Traverseflag, Searchflag);
        }
        public static Int32 GetDocumentDependenciesCount(ISldWorksObject ISldWorksinstance, String Document, Int32 Traverseflag, Int32 Searchflag)
        {
            return ISldWorksinstance.ISldWorksInstance.GetDocumentDependenciesCount(Document, Traverseflag, Searchflag);
        }
        //public static Object OpenDocSilent(ISldWorksObject ISldWorksinstance, String FileName, Int32 Type, Int32& Errors)
        //{
        //    return ISldWorksinstance.ISldWorksInstance.OpenDocSilent(FileName, Type, Errors);
        //}
        //public static IModelDocObject IOpenDocSilent(ISldWorksObject ISldWorksinstance, String FileName, Int32 Type, Int32& Errors)
        //{
        //    return new IModelDocObject(ISldWorksinstance.ISldWorksInstance.IOpenDocSilent(FileName, Type, Errors));
        //}
        public static Int32 CallBack(ISldWorksObject ISldWorksinstance, String CallBackFunc, Int32 DefaultRetVal, String CallBackArgs)
        {
            return ISldWorksinstance.ISldWorksInstance.CallBack(CallBackFunc, DefaultRetVal, CallBackArgs);
        }
        public static Int32 SendMsgToUser2(ISldWorksObject ISldWorksinstance, String Message, Int32 Icon, Int32 Buttons)
        {
            return ISldWorksinstance.ISldWorksInstance.SendMsgToUser2(Message, Icon, Buttons);
        }
        //public static IEnumDocumentsObject EnumDocuments(ISldWorksObject ISldWorksinstance)
        //{
        //    return new IEnumDocumentsObject(ISldWorksinstance.ISldWorksInstance.EnumDocuments());
        //}
        public static Int32 LoadAddIn(ISldWorksObject ISldWorksinstance, String FileName)
        {
            return ISldWorksinstance.ISldWorksInstance.LoadAddIn(FileName);
        }
        public static Int32 UnloadAddIn(ISldWorksObject ISldWorksinstance, String FileName)
        {
            return ISldWorksinstance.ISldWorksInstance.UnloadAddIn(FileName);
        }
        public static Boolean RecordLine(ISldWorksObject ISldWorksinstance, String Text)
        {
            return ISldWorksinstance.ISldWorksInstance.RecordLine(Text);
        }
        public static Object VersionHistory(ISldWorksObject ISldWorksinstance, String FileName)
        {
            return ISldWorksinstance.ISldWorksInstance.VersionHistory(FileName);
        }
        public static String IVersionHistory(ISldWorksObject ISldWorksinstance, String FileName)
        {
            return ISldWorksinstance.ISldWorksInstance.IVersionHistory(FileName);
        }
        public static Object ActiveDoc(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.ActiveDoc;
        }
        public static IModelDocObject IActiveDoc(ISldWorksObject ISldWorksinstance)
        {
            return new IModelDocObject(ISldWorksinstance.ISldWorksInstance.IActiveDoc);
        }
        public static Boolean Visible(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.Visible;
        }
        public static Boolean UserControl(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.UserControl;
        }
        public static String ActivePrinter(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.ActivePrinter;
        }
        public static IModelDoc2Object IActiveDoc2(ISldWorksObject ISldWorksinstance)
        {
            return new IModelDoc2Object(ISldWorksinstance.ISldWorksInstance.IActiveDoc2);
        }
        public static Object UserTypeLibReferences(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.UserTypeLibReferences;
        }
        public static Boolean UserControlBackground(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.UserControlBackground;
        }
        public static Boolean CommandInProgress(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.CommandInProgress;
        }
        public static Boolean TaskPaneIsPinned(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.TaskPaneIsPinned;
        }
        public static IJournalManagerObject JournalManager(ISldWorksObject ISldWorksinstance)
        {
            return new IJournalManagerObject(ISldWorksinstance.ISldWorksInstance.JournalManager);
        }
        public static Int32 FrameLeft(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.FrameLeft;
        }
        public static Int32 FrameTop(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.FrameTop;
        }
        public static Int32 FrameWidth(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.FrameWidth;
        }
        public static Int32 FrameHeight(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.FrameHeight;
        }
        public static Int32 FrameState(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.FrameState;
        }
        public static Boolean EnableFileMenu(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.EnableFileMenu;
        }
        public static Boolean EnableBackgroundProcessing(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.EnableBackgroundProcessing;
        }
        public static Boolean StartupProcessCompleted(ISldWorksObject ISldWorksinstance)
        {
            return ISldWorksinstance.ISldWorksInstance.StartupProcessCompleted;
        }
    }
}