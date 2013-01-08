using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace multisLauncher
{
    class WebViewController
    {
        /*
         * TO LOAD LOCAL HTML PAGE
         *  StorageFile     sf = await Package.Current.InstalledLocation.GetFileAsync("TestPage.html");
         *  uint            length = (uint)sf.Size;
         *  IInputStream    input = await sf.OpenForReadAsync();
         *  byte[]          buffer = new byte[length];
         *  await input.ReadAsync(buffer.AsBuffer(), length, InputStreamOptions.None);
         *  string          content = Encoding.GetEncoding("utf-8").GetString(buffer, 0, buffer.Length);
         *  webView.NavigateToString(content);
        */
        



    }
}
