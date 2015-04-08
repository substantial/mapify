using UnityEngine;
using System;
using System.Collections;

public static class StringExtensions {
  public static string[] SplitOnNewline(this String str) {
    return str.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
  }
}
