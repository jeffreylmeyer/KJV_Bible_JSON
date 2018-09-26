# KJV_Bible_JSON

To use these JSON files copy the BibleFiles\*\*\*.* to a local drive directory such as 
C:\BibleFiles or place into your Documents folder.
Example:
C:\BibleFiles
C:\BibleFiles\\JSONBible
C:\BibleFiles\\JSONBible\\books.json
C:\BibleFiles\\JSONBible\\NewTestament\\{bookname}.json
C:\BibleFiles\\JSONBible\\OldTestament\\{bookname}.json


You will need to know that path if you run the Bible Search 1 software to read the .json Bible.

 Bible Search 1 software is a c# program written with Visual Studio 2015 PRO, but should compile
 using VS Community 2015-2017, also.
 
 When first run it will ask for the \BibleFiles\JSONBible folder path. Make sure you select the
 JSONBible folder and not the parent dir (BibleFiles). The path will be stored in user settings
 i.e. Properties.Settings.Default.JSONBiblePath. You can preset that path in the settings before 
 compiling, if desired.
 
 The software references Newtonsoft.Json which is used for Serializing and Deserializing the json.
 
 This program will search the entire Bible in a split-second (single words or short phrases).
 
 NO WARRANTY OF ANY KIND IS OFFERED FOR THE ABILITY OR INABILITY TO USE THIS SOFTWARE.
 You are free to use as a training/educational tool for creating your own Bible search software.
 
 If you would like to know how I converted the text to .json in the first place, please leave 
 feedback or email me and request I add that project here, also.
 
 
