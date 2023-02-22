using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Core;

public abstract class Entity : Notifiable<Notification>
{
    protected Entity() // Emtpy for EF
    { }

    protected Entity(Guid? id)
    {
        if (id == Guid.Empty || id is null)
            Id = Guid.NewGuid();
        else
            Id = (Guid)id;
    }

    public Guid Id { get; private set; }
}
