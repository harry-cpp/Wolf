﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blue_Eyes_White_Dragon.Presenter;
using Blue_Eyes_White_Dragon.Presenter.Interface;
using Blue_Eyes_White_Dragon.UI.Interface;
using Ninject.Modules;

namespace Blue_Eyes_White_Dragon.Utility.DI
{
    public class PresenterModule : NinjectModule
    {
        public override void Load()
        {
            var kernel = Kernel ?? throw new ArgumentNullException(nameof(Kernel));

            kernel.Bind<IArtworkPickerPresenter>().To<ArtworkPickerPresenter>();
            kernel.Bind<IArtworkEditorPresenter>().To<ArtworkEditorPresenter>().InSingletonScope();
        }
    }
}
