using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace RGZ_Info_systems.Controllers
{
    class WordHandler
    {
        private FileInfo fileInfo;
        public WordHandler(string fileName) 
        { 
            if(File.Exists(fileName))
            {
                fileInfo = new FileInfo(fileName);
            }
            else
            {

            }
        }

        internal void Process(Dictionary<string, string> dictionary)
        {
            Application app = new Application();

            try
            {
                string newFileName = Path.Combine(fileInfo.DirectoryName, DateTime.Now.ToString("yyyyMMdd HHmmss ") + fileInfo.Name);
                File.Copy(fileInfo.FullName, (string)newFileName);

                Object file = fileInfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach(var items in dictionary)
                {
                    Find find = app.Selection.Find;

                    find.Text = items.Key;
                    find.Replacement.Text = items.Value;

                    Object wrap = WdFindWrap.wdFindContinue;
                    Object replace = WdReplace.wdReplaceAll;

                    find.Execute(
                        FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchSoundsLike: missing,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace
                        );
                }

                app.Visible = true;
                app.ActiveDocument.Save();
                app.ActiveDocument.PrintPreview();
                
            }
            catch(Exception e) 
            {
               
            }
            finally 
            {


            }
        }
    }
}
