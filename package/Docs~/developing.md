---
title: Getting started with development in Noir
---

## Setup Local Environment

- Unity 2021.3.22f1 or greater
- VSCode or Rider

### Create Unity Editor Project

1. Open Unity Hub, select "New Project"
2. Make sure the selected editor version is at least v2021.3.22f1
3. Name the project, this can be anything, but `noir-dev` is recommended for clarity
4. Click "Create Project"
5. After Unity load, open the package manager window and select "Install package from disk..."
6. Select the `package.json` file in the root of the directory where you've cloned the Noir project locally
7. You're now all setup to start making changes to the Noir source!


### Enable the Noir test projects

If you want to update or run the edit mode or runtime tests for Noir, you'll need to make the following changes:

1. Open the `manifest.json` file within the `Packages/` folder at the root of your `noir-dev` Unity project
2. Add the JSON below to the file and save it

```js
{
    "dependencies": {
        //... ignore this section here
    },
    "testables": [
        "io.troublecat.noir"
    ]
}
```

This will tell Unity to load the test projects so that you can run them within the project and make changes in your editor with code-completion/error checking.
