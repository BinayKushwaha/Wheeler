using System;
using System.Collections.Generic;
using System.Text;
using Wheeler.Database.Context;

namespace Wheeler.Database.Repository
{
    public abstract class BaseRepository
    {
        public ApplicationContext ApplicationContext { get; private set; }

        public BaseRepository(ApplicationContext  applicationContext)
        {
            this.ApplicationContext = applicationContext;
        }
        public ApplicationContext DataContext
        {
            get 
            {
                return ApplicationContext;
            }
        }
    }
}
