using Interpreter.Exceptions;

namespace Interpreter
{
    public class Data_type
    {
        public virtual int Get_int_val()
        {
            throw new Our_runtime_exception("Не является целочисленным типом данных");
        }

        public virtual bool Get_bool_val()
        {
            throw new Our_runtime_exception("Не является bool переменной");
        }

        public virtual void Set_bool_val(bool value)
        {
            throw new Our_runtime_exception("Не является bool переменной");
        }

        public virtual void Set_int_value(int value)
        {
            throw new Our_runtime_exception("Не является целочисленной переменной");
        }

        public virtual Data_type Get_data_type_at_index(int index)
        {
            throw new Our_runtime_exception("Не является массивом");
        }
    }
}
