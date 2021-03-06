﻿using System;
using System.Windows.Media.Imaging;
using GitHub.ViewModels;
using GitHub.ViewModels.GitHubPane;
using ReactiveUI;

namespace GitHub.SampleData
{
    public sealed class PullRequestCheckViewModelDesigner : ViewModelBase, IPullRequestCheckViewModel
    {
        public string Title { get; set; } = "continuous-integration/appveyor/pr";

        public string Description { get; set; } = "AppVeyor build failed";

        public PullRequestCheckStatus Status { get; set; } = PullRequestCheckStatus.Failure;

        public Uri DetailsUrl { get; set; } = new Uri("http://github.com");

        public string AvatarUrl { get; set; } = "https://avatars1.githubusercontent.com/u/417571?s=88&v=4";

        public BitmapImage Avatar { get; set; } = null;

        public ReactiveCommand<object> OpenDetailsUrl { get; set; } = null;
    }
}