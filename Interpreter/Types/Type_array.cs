using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interpreter.Exceptions;

namespace Interpreter
{
    class Type_array : Data_type
    {
        private Type_int_var[] array;
        private int size_of_array;

        public Type_array(int size)
        {
            array = new Type_int_var[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = new Type_int_var();
            }
            size_of_array = size;
        }

        public override Data_type Get_data_type_at_index(int index)
        {
            if (index < 0 || index >= size_of_array)
            {
                throw new Our_runtime_exception("Индекс вне границ массива");
            }
            return array[index];
        }
    }
}
