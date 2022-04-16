using Word = Microsoft.Office.Interop.Word;
using System.Diagnostics;

namespace ProbalityTheory
{
    internal class WordCreator
    {
        private FileInfo _fileInfo;
        Word.Application app = null;

        public WordCreator(string fileName) {
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else {
                throw new Exception("File not found");
            }
        }

        internal void Process(Dictionary<string, string> items)
        {
            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName;
                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace
                        );
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        internal void saveDocument(string fileName) {
            if (app != null)
            {
                app.ActiveDocument.SaveAs2(fileName);
                app.ActiveDocument.Close();
                app.Quit();
            }
        }
    }
}
