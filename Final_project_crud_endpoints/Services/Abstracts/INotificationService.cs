﻿using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.DataBase.Entities.Identity;

namespace Final_project_crud_endpoints.Services.Abstracts
{
    public interface INotificationService
    {
        Task PrepareAndSendSMSNotifcation(Dictionary<string, string> OldAndNewValues, string recipient, string template);
        Task PrepareAndSendSMSNotifcation(string recipient, string template);
        Task<Email> PrepareAndSendEmailNotifcation(User user, string subject, string body);
        Task<Email> PrepareAndSendEmailNotifcation(Dictionary<string, string> OldAndNewValues, User user, string subject, string body);
    }
}
