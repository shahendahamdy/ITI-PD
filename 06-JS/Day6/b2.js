onload = function () {
  this.window.oncontextmenu = function () {
    event.preventDefault();
    document.getElementsByTagName("p")[0].innerHTML =
      "context menu  won't appear";
  };
};
