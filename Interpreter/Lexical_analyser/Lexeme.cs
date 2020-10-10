namespace Interpreter.LexicalAnalysis
{
    internal class Lexeme
    {
        public string val { get; set; }
        public int line { get; set; }
        public int char_pos { get; set; }

        public string Start_at()
        {
            return string.Format("Line: {0}, Col: {1}", line, char_pos);
        }

        public Lexical_analyser.TYPE Type { get; set; }
    }
}