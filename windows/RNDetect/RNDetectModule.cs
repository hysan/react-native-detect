using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Detect.RNDetect
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDetectModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDetectModule"/>.
        /// </summary>
        internal RNDetectModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDetect";
            }
        }
    }
}
