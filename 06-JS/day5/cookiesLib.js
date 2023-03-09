function getCookie(cookieName) {
  var res = document.cookie.split(";");
  //console.log(res.length);
  for (var i = 0; i < res.length; i++) {
    var res2 = res[i].split("=");
    if (res2[0] == cookieName || res2[0] == " " + cookieName)
      return res2[1] + " ";
  }
  return "-1";
}
function setCookie(cookieName, cookieValue, expiryDate = null) {
  document.cookie = cookieName + "=" + cookieValue + ";";
  console.log(cookieName + "=" + cookieValue + ";");

  return true;
}
function deleteCookie(cookieName) {
  setCookie(cookieName, "", "Thu, 01 Jan 1970 00:00:00 UTC");
}

function allCookieList() {
  var res = document.cookie.split(";");

  return res;
}
function hasCookie(cookieName) {
  var b = getCookie(cookieName);
  if (b == -1) return false;
  return true;
}
function getCookieCounter() {
  var visits = getCookie("counter");
  visits = parseInt(visits) + 1;
  setCookie("counter", visits);
  return visits;
}
