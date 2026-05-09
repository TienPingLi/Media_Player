
# 多媒體播放器

<img width="925" height="756" alt="image" src="https://github.com/user-attachments/assets/b7516d24-eb8e-4592-9107-54d8062388e6" />

## 一、專案簡介

本專案為「視窗程式設計 (II)」課程中的上課練習：**多媒體播放器**。

程式使用 C# Windows Forms 製作圖形化介面，並結合 Windows Media Player 元件來播放多媒體檔案。使用者可以透過「瀏覽」按鈕選擇本機影片或音訊檔案，再使用「播放」、「暫停」、「停止」等按鈕控制播放狀態。

本練習主要目的為熟悉 Windows Forms 介面設計、OpenFileDialog 檔案選擇功能、Windows Media Player 元件的使用方式，以及多媒體播放控制的基本操作。

---

## 二、專案功能

本程式提供以下功能：

1. **瀏覽多媒體檔案**
   - 使用 `OpenFileDialog` 開啟檔案選擇視窗。
   - 可選擇常見多媒體格式，例如 `.wmv`、`.mp4`、`.avi`、`.mp3`、`.wav` 等檔案。
   - 選取檔案後，將檔案路徑指定給 Windows Media Player 的 `URL` 屬性。

2. **播放多媒體檔案**
   - 按下「播放」按鈕後，透過 `Ctlcontrols.play()` 開始播放。

3. **暫停播放**
   - 按下「暫停」按鈕後，透過 `Ctlcontrols.pause()` 暫停目前播放內容。

4. **停止播放**
   - 按下「停止」按鈕後，透過 `Ctlcontrols.stop()` 停止播放。

5. **結束程式**
   - 按下「結束」按鈕可關閉應用程式。
   - 關閉前可停止目前播放中的多媒體內容。

6. **GUI 介面設計**
   - 上方顯示程式標題。
   - 中間為影片播放區。
   - 下方為控制按鈕區。
   - 播放器內建控制列可設定為隱藏，改由自訂按鈕控制播放。

---

## 三、開發環境

| 項目 | 內容 |
|---|---|
| 開發工具 | Visual Studio 2022 |
| 程式語言 | C# |
| 專案類型 | Windows Forms App |
| 使用框架 | .NET Framework / Windows Forms |
| 主要元件 | Windows Media Player ActiveX Control |
| 主要命名空間 | `System.Windows.Forms` |

---

## 四、使用技術

### 1. Windows Forms

Windows Forms 是 C# 用來建立桌面視窗應用程式的技術。本專案使用 Form、Panel、Label、Button 與 OpenFileDialog 建立多媒體播放器介面。

---

### 2. Windows Media Player 元件

本專案使用 Windows Media Player 元件作為影片與音訊播放核心。

常用屬性與方法如下：

| 屬性 / 方法 | 說明 |
|---|---|
| `URL` | 設定或取得要播放的多媒體檔案完整路徑 |
| `uiMode` | 設定 Windows Media Player 內建控制列顯示模式 |
| `stretchToFit` | 設定影片是否自動配合播放區大小 |
| `Ctlcontrols.play()` | 播放多媒體檔案 |
| `Ctlcontrols.pause()` | 暫停播放 |
| `Ctlcontrols.stop()` | 停止播放 |

---

### 3. OpenFileDialog

`OpenFileDialog` 用來讓使用者從電腦中選擇要播放的多媒體檔案。

```csharp
OpenFileDialog ofd = new OpenFileDialog();

ofd.Filter =
    "WMV files (*.wmv)|*.wmv|" +
    "MP4 files (*.mp4)|*.mp4|" +
    "AVI files (*.avi)|*.avi|" +
    "MP3 files (*.mp3)|*.mp3|" +
    "WAV files (*.wav)|*.wav|" +
    "All files (*.*)|*.*";
