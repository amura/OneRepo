using System;
using CQRSlite.Commands;

namespace OneRepoCQRS.WriteModel.Commands
{
    public class CreateRepositoryItem : ICommand
    {
        public CreateRepositoryItem(Guid newGuid, string name, string description, long size)
        {
            Id = newGuid;
        }

        public Guid Id  { get; set; }

        public int ExpectedVersion { get; set; }
    }
}