﻿using System;

namespace ACMandS
{
    partial class ASM_Executor
    {
        private unsafe void Push(string[] operands)
        {
            if (IsNumber(operands[0]))
            {
                STACK.Push(int.Parse(operands[0]));
                return;
            }
            int* digit = null;
            GetPointer(operands[0], ref digit);
            STACK.Push(*digit);
        }

        private unsafe void Pop(string[] operands)
        {
            int* digit = null;
            GetPointer(operands[0], ref digit);
            *digit = STACK.Pop();
        }
    }
}
