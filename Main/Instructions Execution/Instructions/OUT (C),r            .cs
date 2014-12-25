﻿
// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "OUT (C),r            .tt" instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The OUT (C),A instruction.
        /// </summary>
        byte OUT_C_A()
        {
            FetchFinished();

            ProcessorAgent.WriteToPort(Registers.C, Registers.A);

            return 12;
        }

        /// <summary>
        /// The OUT (C),B instruction.
        /// </summary>
        byte OUT_C_B()
        {
            FetchFinished();

            ProcessorAgent.WriteToPort(Registers.C, Registers.B);

            return 12;
        }

        /// <summary>
        /// The OUT (C),C instruction.
        /// </summary>
        byte OUT_C_C()
        {
            FetchFinished();

            ProcessorAgent.WriteToPort(Registers.C, Registers.C);

            return 12;
        }

        /// <summary>
        /// The OUT (C),D instruction.
        /// </summary>
        byte OUT_C_D()
        {
            FetchFinished();

            ProcessorAgent.WriteToPort(Registers.C, Registers.D);

            return 12;
        }

        /// <summary>
        /// The OUT (C),E instruction.
        /// </summary>
        byte OUT_C_E()
        {
            FetchFinished();

            ProcessorAgent.WriteToPort(Registers.C, Registers.E);

            return 12;
        }

        /// <summary>
        /// The OUT (C),H instruction.
        /// </summary>
        byte OUT_C_H()
        {
            FetchFinished();

            ProcessorAgent.WriteToPort(Registers.C, Registers.H);

            return 12;
        }

        /// <summary>
        /// The OUT (C),L instruction.
        /// </summary>
        byte OUT_C_L()
        {
            FetchFinished();

            ProcessorAgent.WriteToPort(Registers.C, Registers.L);

            return 12;
        }

        /// <summary>
        /// The OUT (C),0 instruction.
        /// </summary>
        byte OUT_C_0()
        {
            FetchFinished();

            ProcessorAgent.WriteToPort(Registers.C, 0);

            return 12;
        }

    }
}