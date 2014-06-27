using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;

namespace VStorm.Models.ContactsModel
{
    public class ContactsProvider : EFContextProvider<ContactsContext>, IContextProvider<ContactsContext>
    {
        protected override bool BeforeSaveEntity(EntityInfo entityInfo)
        {
            // return false if we don’t want the entity saved.
            return entityInfo.EntityState == EntityState.Added;
        }

        ContactsContext IContextProvider<ContactsContext>.Context
        {
            get { return base.Context; }
        }
    }

    public interface IContextProvider<out T>
    {
        string Metadata();
        T Context { get; }
    }
}