using System;
using System.Collections.Generic;
using System.IO;

namespace Interpreter
{
    internal class Main_program
    {
        private static void Main(string[] args)
        {
            Our_interpreter interpreter = new Our_interpreter();
            string directory = "../../../../Tests";
            if (Directory.Exists(directory))
            {
                var tests = Directory.GetFiles(directory, "*.test");
                Console.WriteLine("Обнаружено {0} тестов.", tests.Length);
                foreach (var test in tests)
                {
                    string test_file_name = Path.GetFileNameWithoutExtension(test);
                    string input_path = directory + @"\" + test_file_name + ".input";
                    string output_path = directory + @"\" + test_file_name + ".output";
                    if (!File.Exists(input_path))
                    {
                        Console.WriteLine("Входные данные для теста" + test_file_name + " не обнаружены!");
                        continue;
                    }
                    if (!File.Exists(output_path))
                    {
                        Console.WriteLine("Выходные данные для теста" + test_file_name + " не обнаружены!");
                        continue;
                    }
                    Console.WriteLine("Начинаю тест " + test_file_name);
                    StreamReader test_input_reader = new StreamReader(input_path);
                    string temp_file_path = directory + @"\" + test_file_name + ".TMP";
                    StreamWriter test_output_writer = new StreamWriter(temp_file_path);

                    interpreter.Interprete(test, test_input_reader, test_output_writer);

                    test_input_reader.Close();
                    test_output_writer.Close();

                    using (StreamReader test_output_reader = new StreamReader(output_path),
                                        test_real_output_reader = new StreamReader(temp_file_path))
                    {
                        string output = test_output_reader.ReadToEnd();
                        string real_output = test_real_output_reader.ReadToEnd();
                        if (String.Equals(output, real_output))
                        {
                            Console.WriteLine("Тест {0} успешно пройден", test_file_name);
                        }
                        else
                        {
                            Console.WriteLine("Тест {0} не пройден", test_file_name);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Директория тестов не найдена.");
            }
            Console.ReadLine();
        }
    }
}