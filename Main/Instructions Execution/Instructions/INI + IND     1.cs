﻿// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "INI + IND     .tt" instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The INI instruction.
        /// </summary>
        byte INI()
        {
            FetchFinished();

            var portNumber = Registers.C;
            var address = Registers.HL;
            var value = ProcessorAgent.ReadFromPort(portNumber);
            ProcessorAgent.WriteToMemory(address.ToUShort(), value);

            Registers.HL = address.Inc();
            var counter = Registers.B;
            counter = counter.Dec();
            Registers.B = counter;
            Registers.ZF = (counter == 0);
            Registers.NF = 1;
            Registers.SF = counter.GetBit(7);
            SetFlags3and5From(counter);

            return 16;
        }

        /// <summary>
        /// The IND instruction.
        /// </summary>
        byte IND()
        {
            FetchFinished();

            var portNumber = Registers.C;
            var address = Registers.HL;
            var value = ProcessorAgent.ReadFromPort(portNumber);
            ProcessorAgent.WriteToMemory(address.ToUShort(), value);

            Registers.HL = address.Dec();
            var counter = Registers.B;
            counter = counter.Dec();
            Registers.B = counter;
            Registers.ZF = (counter == 0);
            Registers.NF = 1;
            Registers.SF = counter.GetBit(7);
            SetFlags3and5From(counter);

            return 16;
        }

    }
}