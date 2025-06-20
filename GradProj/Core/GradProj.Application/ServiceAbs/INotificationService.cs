﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradProj.Domain.Entities;

namespace GradProj.Application.ServiceAbs
{
    public interface INotificationService : IService<Notification>
    {
        Task CreateAsync(Notification notification); //dto?
        Task<IEnumerable<Notification>> GetNotificationsByUserIdAsync(Guid userId);
        Task MarkAsReadAsync(Guid notificationId);
    }
}
