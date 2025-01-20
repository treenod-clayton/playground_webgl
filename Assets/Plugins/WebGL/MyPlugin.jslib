mergeInto(LibraryManager.library, {
  UnityToNextJS: function (userName, score) {
    window.dispatchReactUnityEvent("UnityToNextJS", UTF8ToString(userName), score);
  },
});