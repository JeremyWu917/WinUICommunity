﻿using Microsoft.Windows.ApplicationModel.Resources;

namespace WinUICommunity;
public interface IResourceHelper
{
    ResourceManager ResourceManager { get; set; }
    ResourceContext ResourceContext { get; set; }

    void Initialize();
    void Initialize(ResourceManager resourceManager);
    void Initialize(ResourceManager resourceManager, ResourceContext resourceContext);
    List<string> GetAllResourcesKeys(string identifier = null);
    string GetString(string key);
    string GetString(string key, string language);
    string GetStringFromResource(string key, string filename);
    string GetStringFromResource(string key, string language, string filename);
}
