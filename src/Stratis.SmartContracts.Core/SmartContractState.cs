﻿using System;

namespace Stratis.SmartContracts.Core
{
    /// <summary>
    /// Smart contract state that gets injected into the smart contract by the <see cref="ReflectionVirtualMachine"/>.
    /// </summary>
    /// <remarks>
    /// TODO: SmartContractState is basically the same thing as <see cref="SmartContractExecutionContext"/> so merge them eventually.
    /// </remarks>
    public sealed class SmartContractState : ISmartContractState
    {
        public SmartContractState(
            Block block,
            Message message,
            IPersistentState persistentState,
            IGasMeter gasMeter,
            IInternalTransactionExecutor internalTransactionExecutor,
            Func<ulong> getBalance)
        {
            this.Block = block;
            this.Message = message;
            this.PersistentState = persistentState;
            this.GasMeter = gasMeter;
            this.InternalTransactionExecutor = internalTransactionExecutor;
            this.GetBalance = getBalance;
        }

        public Block Block { get; }

        public Message Message { get; }

        public IPersistentState PersistentState { get; }

        public IGasMeter GasMeter { get; }

        public IInternalTransactionExecutor InternalTransactionExecutor { get; }

        public Func<ulong> GetBalance { get; }
    }
}