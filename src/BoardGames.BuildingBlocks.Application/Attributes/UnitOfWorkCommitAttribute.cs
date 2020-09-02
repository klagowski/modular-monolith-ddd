using System;

namespace BoardGames.BuildingBlocks.Application.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class UnitOfWorkCommitAttribute : Attribute
    {
    }
}
