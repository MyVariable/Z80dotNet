﻿// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change ADD + ADC + SUB + SBC A, r + (HL).tt instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The ADC A,A instruction.
        /// </summary>
        private byte ADC_A_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.A;
			var newValue = (byte)oldValue.Add(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SBC A,A instruction.
        /// </summary>
        private byte SBC_A_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.A;
			var newValue = (byte)oldValue.Sub(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADD A,A instruction.
        /// </summary>
        private byte ADD_A_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.A;
			var newValue = (byte)oldValue.Add(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SUB A,A instruction.
        /// </summary>
        private byte SUB_A()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.A;
			var newValue = (byte)oldValue.Sub(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADC A,B instruction.
        /// </summary>
        private byte ADC_A_B()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.B;
			var newValue = (byte)oldValue.Add(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SBC A,B instruction.
        /// </summary>
        private byte SBC_A_B()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.B;
			var newValue = (byte)oldValue.Sub(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADD A,B instruction.
        /// </summary>
        private byte ADD_A_B()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.B;
			var newValue = (byte)oldValue.Add(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SUB A,B instruction.
        /// </summary>
        private byte SUB_B()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.B;
			var newValue = (byte)oldValue.Sub(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADC A,C instruction.
        /// </summary>
        private byte ADC_A_C()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.C;
			var newValue = (byte)oldValue.Add(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SBC A,C instruction.
        /// </summary>
        private byte SBC_A_C()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.C;
			var newValue = (byte)oldValue.Sub(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADD A,C instruction.
        /// </summary>
        private byte ADD_A_C()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.C;
			var newValue = (byte)oldValue.Add(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SUB A,C instruction.
        /// </summary>
        private byte SUB_C()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.C;
			var newValue = (byte)oldValue.Sub(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADC A,D instruction.
        /// </summary>
        private byte ADC_A_D()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.D;
			var newValue = (byte)oldValue.Add(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SBC A,D instruction.
        /// </summary>
        private byte SBC_A_D()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.D;
			var newValue = (byte)oldValue.Sub(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADD A,D instruction.
        /// </summary>
        private byte ADD_A_D()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.D;
			var newValue = (byte)oldValue.Add(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SUB A,D instruction.
        /// </summary>
        private byte SUB_D()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.D;
			var newValue = (byte)oldValue.Sub(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADC A,E instruction.
        /// </summary>
        private byte ADC_A_E()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.E;
			var newValue = (byte)oldValue.Add(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SBC A,E instruction.
        /// </summary>
        private byte SBC_A_E()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.E;
			var newValue = (byte)oldValue.Sub(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADD A,E instruction.
        /// </summary>
        private byte ADD_A_E()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.E;
			var newValue = (byte)oldValue.Add(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SUB A,E instruction.
        /// </summary>
        private byte SUB_E()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.E;
			var newValue = (byte)oldValue.Sub(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADC A,H instruction.
        /// </summary>
        private byte ADC_A_H()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.H;
			var newValue = (byte)oldValue.Add(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SBC A,H instruction.
        /// </summary>
        private byte SBC_A_H()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.H;
			var newValue = (byte)oldValue.Sub(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADD A,H instruction.
        /// </summary>
        private byte ADD_A_H()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.H;
			var newValue = (byte)oldValue.Add(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SUB A,H instruction.
        /// </summary>
        private byte SUB_H()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.H;
			var newValue = (byte)oldValue.Sub(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADC A,L instruction.
        /// </summary>
        private byte ADC_A_L()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.L;
			var newValue = (byte)oldValue.Add(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SBC A,L instruction.
        /// </summary>
        private byte SBC_A_L()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.L;
			var newValue = (byte)oldValue.Sub(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADD A,L instruction.
        /// </summary>
        private byte ADD_A_L()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.L;
			var newValue = (byte)oldValue.Add(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The SUB A,L instruction.
        /// </summary>
        private byte SUB_L()
        {
            FetchFinished();

            var oldValue = Registers.A;
            var valueAdded = Registers.L;
			var newValue = (byte)oldValue.Sub(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 4;
        }

        /// <summary>
        /// The ADC A,(HL) instruction.
        /// </summary>
        private byte ADC_A_aHL()
        {
            FetchFinished();

            var oldValue = Registers.A;
			var valueAdded = ProcessorAgent.ReadFromMemory(Registers.HL.ToUShort());
			var newValue = (byte)oldValue.Add(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 7;
        }

        /// <summary>
        /// The SBC A,(HL) instruction.
        /// </summary>
        private byte SBC_A_aHL()
        {
            FetchFinished();

            var oldValue = Registers.A;
			var valueAdded = ProcessorAgent.ReadFromMemory(Registers.HL.ToUShort());
			var newValue = (byte)oldValue.Sub(valueAdded + Registers.CF);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 7;
        }

        /// <summary>
        /// The ADD A,(HL) instruction.
        /// </summary>
        private byte ADD_A_aHL()
        {
            FetchFinished();

            var oldValue = Registers.A;
			var valueAdded = ProcessorAgent.ReadFromMemory(Registers.HL.ToUShort());
			var newValue = (byte)oldValue.Add(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) < (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 1) && (newValueMSB == 0);
            Registers.PF = (oldValueMSB == valueAdded.GetBit(7)) && (oldValueMSB != newValueMSB);

            Registers.NF = 0;
            SetFlags3and5From(newValue);

            return 7;
        }

        /// <summary>
        /// The SUB A,(HL) instruction.
        /// </summary>
        private byte SUB_aHL()
        {
            FetchFinished();

            var oldValue = Registers.A;
			var valueAdded = ProcessorAgent.ReadFromMemory(Registers.HL.ToUShort());
			var newValue = (byte)oldValue.Sub(valueAdded);
            Registers.A = newValue;

            Registers.SF = newValue.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newValue & 0x0F) > (oldValue & 0x0F);
            var oldValueMSB = oldValue.GetBit(7);
            var newValueMSB = newValue.GetBit(7);
            Registers.CF = (oldValueMSB == 0) && (newValueMSB == 1);
			var valueAddedMSB = valueAdded.GetBit(7);
			Registers.PF = (oldValueMSB != valueAddedMSB) && (valueAddedMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue);

            return 7;
        }

    }
}