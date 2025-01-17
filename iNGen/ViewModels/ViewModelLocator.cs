﻿using GalaSoft.MvvmLight.Ioc;
using iNGen.ViewModels.ChatViewModels;
using Microsoft.Practices.ServiceLocation;

namespace iNGen.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<NavigationViewModel>();
            SimpleIoc.Default.Register <ScheduledCommandsViewModel>();
            SimpleIoc.Default.Register<ChatViewModel>();
            SimpleIoc.Default.Register<ConsoleViewModel>();
            SimpleIoc.Default.Register<PlayersViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();            
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]


        public ConsoleViewModel Console
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ConsoleViewModel>();
            }
        }

        public PlayersViewModel Players
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PlayersViewModel>();
            }
        }
        
        public ChatViewModel Chat
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ChatViewModel>();
            }
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public ScheduledCommandsViewModel Scheduled
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ScheduledCommandsViewModel>();
            }
        }

        public NavigationViewModel Navigation
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NavigationViewModel>();
            }
        }

        public HomeViewModel Home
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HomeViewModel>();
            }
        }

    }
}
