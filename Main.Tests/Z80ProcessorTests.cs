﻿using NUnit.Framework;

namespace Konamiman.Z80dotNet.Tests
{
    public class Z80ProcessorTests
    {
        Z80Processor Sut { get; set; }

        [SetUp]
        public void Setup()
        {
            Sut = new Z80Processor();
        }

        [Test]
        public void Can_create_instances()
        {
            Assert.IsNotNull(Sut);
        }

        [Test]
        public void Has_proper_defaults()
        {
            Assert.AreEqual(4, Sut.ClockFrequencyInMHz);
            Assert.AreEqual(1, Sut.ClockSpeedFactor);

            Assert.IsFalse(Sut.AutoStopOnDiPlusHalt);
            Assert.IsFalse(Sut.AutoStopOnRetWithStackEmpty);

            Assert.IsInstanceOf<PlainMemory>(Sut.Memory);
            Assert.AreEqual(65536, Sut.Memory.Size);
            Assert.IsInstanceOf<PlainMemory>(Sut.PortsSpace);
            Assert.AreEqual(256, Sut.PortsSpace.Size);

            for(int i = 0; i < 65536; i++) {
                Assert.AreEqual(MemoryAccessMode.ReadAndWrite, Sut.GetMemoryAccessMode((ushort)i));
                Assert.AreEqual(0, Sut.GetMemoryWaitStatesForM1((ushort)i));
                Assert.AreEqual(0, Sut.GetMemoryWaitStatesForNonM1((ushort)i));
            }       
            for(int i = 0; i < 256; i++) {
                Assert.AreEqual(MemoryAccessMode.ReadAndWrite, Sut.GetPortAccessMode((byte) i));
                Assert.AreEqual(0, Sut.GetPortWaitStates((byte) i));
            }

            Assert.IsInstanceOf<Z80Registers>(Sut.Registers);
            Assert.IsInstanceOf<MainZ80Registers>(Sut.Registers.Main);
            Assert.IsInstanceOf<MainZ80Registers>(Sut.Registers.Alternate);

            Assert.IsInstanceOf<Z80InstructionExecutor>(Sut.InstructionExecutor);
            Assert.AreSame(Sut, Sut.InstructionExecutor.ProcessorAgent);
            Assert.IsInstanceOf<PeriodWaiter>(Sut.PeriodWaiter);
        }
    }
}