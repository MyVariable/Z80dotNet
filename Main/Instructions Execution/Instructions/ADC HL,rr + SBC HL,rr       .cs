﻿// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "ADC HL,rr + SBC HL,rr       .tt" instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The ADC HL,BC instruction
        /// </summary>
        byte ADC_HL_BC()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToAdd = Registers.BC;
            var newValue = oldValue.Add(valueToAdd).Add((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) < (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 1) && (newHighByte.GetBit(7) == 0);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
 
			var valueToAddHighByte = Registers.B;
            Registers.PF = (oldValueMSB == valueToAddHighByte.GetBit(7)) && (oldValueMSB != newValueMSB);
            Registers.NF = 0;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

        /// <summary>
        /// The SBC HL,BC instruction
        /// </summary>
        byte SBC_HL_BC()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToAdd = Registers.BC;
            var newValue = oldValue.Sub(valueToAdd).Sub((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) > (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 0) && (newHighByte.GetBit(7) == 1);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
 
			var valueToAddHighByte = Registers.B;
			var valueToAddMSB = valueToAddHighByte.GetBit(7);
			Registers.PF = (oldValueMSB != valueToAddMSB) && (valueToAddMSB == newValueMSB);
            Registers.NF = 1;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

        /// <summary>
        /// The ADC HL,DE instruction
        /// </summary>
        byte ADC_HL_DE()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToAdd = Registers.DE;
            var newValue = oldValue.Add(valueToAdd).Add((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) < (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 1) && (newHighByte.GetBit(7) == 0);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
 
			var valueToAddHighByte = Registers.D;
            Registers.PF = (oldValueMSB == valueToAddHighByte.GetBit(7)) && (oldValueMSB != newValueMSB);
            Registers.NF = 0;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

        /// <summary>
        /// The SBC HL,DE instruction
        /// </summary>
        byte SBC_HL_DE()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToAdd = Registers.DE;
            var newValue = oldValue.Sub(valueToAdd).Sub((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) > (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 0) && (newHighByte.GetBit(7) == 1);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
 
			var valueToAddHighByte = Registers.D;
			var valueToAddMSB = valueToAddHighByte.GetBit(7);
			Registers.PF = (oldValueMSB != valueToAddMSB) && (valueToAddMSB == newValueMSB);
            Registers.NF = 1;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

        /// <summary>
        /// The ADC HL,HL instruction
        /// </summary>
        byte ADC_HL_HL()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToAdd = Registers.HL;
            var newValue = oldValue.Add(valueToAdd).Add((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) < (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 1) && (newHighByte.GetBit(7) == 0);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
 
			var valueToAddHighByte = Registers.H;
            Registers.PF = (oldValueMSB == valueToAddHighByte.GetBit(7)) && (oldValueMSB != newValueMSB);
            Registers.NF = 0;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

        /// <summary>
        /// The SBC HL,HL instruction
        /// </summary>
        byte SBC_HL_HL()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToAdd = Registers.HL;
            var newValue = oldValue.Sub(valueToAdd).Sub((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) > (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 0) && (newHighByte.GetBit(7) == 1);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
 
			var valueToAddHighByte = Registers.H;
			var valueToAddMSB = valueToAddHighByte.GetBit(7);
			Registers.PF = (oldValueMSB != valueToAddMSB) && (valueToAddMSB == newValueMSB);
            Registers.NF = 1;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

        /// <summary>
        /// The ADC HL,SP instruction
        /// </summary>
        byte ADC_HL_SP()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToAdd = Registers.SP;
            var newValue = oldValue.Add(valueToAdd).Add((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) < (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 1) && (newHighByte.GetBit(7) == 0);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
			var valueToAddHighByte = Registers.SP.GetHighByte();
            Registers.PF = (oldValueMSB == valueToAddHighByte.GetBit(7)) && (oldValueMSB != newValueMSB);
            Registers.NF = 0;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

        /// <summary>
        /// The SBC HL,SP instruction
        /// </summary>
        byte SBC_HL_SP()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToAdd = Registers.SP;
            var newValue = oldValue.Sub(valueToAdd).Sub((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) > (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 0) && (newHighByte.GetBit(7) == 1);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
			var valueToAddHighByte = Registers.SP.GetHighByte();
			var valueToAddMSB = valueToAddHighByte.GetBit(7);
			Registers.PF = (oldValueMSB != valueToAddMSB) && (valueToAddMSB == newValueMSB);
            Registers.NF = 1;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

    }
}