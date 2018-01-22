
# react-native-detect

## Getting started

`$ npm install react-native-detect --save`

### Mostly automatic installation

`$ react-native link react-native-detect`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-detect` and add `RNDetect.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNDetect.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.lovescomputers.RNDetectPackage;` to the imports at the top of the file
  - Add `new RNDetectPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-detect'
  	project(':react-native-detect').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-detect/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-detect')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNDetect.sln` in `node_modules/react-native-detect/windows/RNDetect.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Detect.RNDetect;` to the usings at the top of the file
  - Add `new RNDetectPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNDetect from 'react-native-detect';

// TODO: What to do with the module?
RNDetect;
```
  