﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdeaSeedCMSAdmin.Presenters.ViewInterfaces;
using IdeaSeedCMS.Core.Domain;
using IdeaSeedCMS.Core.Security;
using IdeaSeed.Core;
using System.Configuration;
using IdeaSeedCMS.Services;
using IdeaSeedCMS.Core;

namespace IdeaSeedCMSAdmin.Presenters
{
    public class ProfilePresenter : Presenter
    {
        IProfileView _view;

        public ProfilePresenter(IProfileView view, ISessionProvider session)
            : base(view, session)
        {
            _view = base.GetView<IProfileView>();
            _view.InitView += new EventHandler(_view_InitView);
            _view.LoadView += new EventHandler(_view_LoadView);
            _view.UnloadView += new EventHandler(_view_UnloadView);
        }

        void _view_UnloadView(object sender, EventArgs e)
        {

        }

        void _view_LoadView(object sender, EventArgs e)
        {
            
        }

        void _view_InitView(object sender, EventArgs e)
        {

        }
    }
}