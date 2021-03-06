﻿namespace InterpreterPattern
{
    public class Constant : IExpression
    {
        private readonly int _value;

        public Constant(int value)
        {
            _value = value;
        }

        public int Operate()
        {
            return _value;
        }
    }
}
