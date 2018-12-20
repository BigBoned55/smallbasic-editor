﻿// <copyright file="RunPage.cs" company="2018 Omar Tawfik">
// Copyright (c) 2018 Omar Tawfik. All rights reserved. Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

namespace SuperBasic.Editor.Components.Pages.Run
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using SuperBasic.Compiler;
    using SuperBasic.Editor.Components.Display;
    using SuperBasic.Editor.Components.Layout;
    using SuperBasic.Editor.Components.Toolbox;
    using SuperBasic.Editor.Libraries;
    using SuperBasic.Editor.Libraries.Utilities;
    using SuperBasic.Editor.Store;
    using SuperBasic.Utilities;
    using SuperBasic.Utilities.Resources;

    public sealed class RunPage : MainLayout
    {
        private readonly AsyncEngine engine = new AsyncEngine(isDebugging: false);

        private bool isInitialized;

        public static void Inject(TreeComposer composer)
        {
            composer.Inject<RunPage>();
        }

        protected override void OnInit()
        {
            if (CompilationStore.Compilation.Diagnostics.Any())
            {
                NavigationStore.NagivateTo(NavigationStore.PageId.Edit);
                return;
            }
        }

        protected override void ComposeBody(TreeComposer composer)
        {
            composer.Element("run-page", body: () =>
            {
                EngineDisplay.Inject(composer);
            });
        }

        protected override void ComposeLeftActions(TreeComposer composer)
        {
            Actions.Action(composer, "back", EditorResources.Actions_Back, () =>
            {
                this.engine.Stop();
                NavigationStore.NagivateTo(NavigationStore.PageId.Edit);
                return Task.CompletedTask;
            });
        }

        protected override async Task OnAfterRenderAsync()
        {
            if (!this.isInitialized)
            {
                this.isInitialized = true;
                await Task.Run(() => this.engine.Start()).ConfigureAwait(false);
            }
        }
    }
}