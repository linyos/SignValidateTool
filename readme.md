# SignValidateTool

## 專案簡介

SignValidateTool 是一個 Windows Forms 應用程式，用於批次驗證指定資料夾內所有 DLL 檔案的簽章狀態。透過整合 SignDotNet.exe 工具，協助開發者快速檢查 DLL 是否已正確簽章。

## 功能特色

- 選擇 DLL 資料夾與 SignDotNet 工具路徑
- 一鍵批次驗證所有 DLL 檔案
- 於介面即時顯示驗證進度與結果
- 支援錯誤提示與操作狀態回復

## 使用方式

1. 啟動程式。
2. 點選「選擇 DLL 資料夾」選取欲驗證的 DLL 檔案所在資料夾。
3. 點選「選擇簽章工具路徑」選取 SignDotNet.exe 所在資料夾。
4. 點選「開始驗證」按鈕，程式將自動批次驗證所有 DLL 檔案。
5. 驗證結果與錯誤訊息將顯示於下方輸出區域。

## 注意事項

- 請確認 SignDotNet.exe 已放置於指定路徑下。
- 僅支援 .dll 檔案。
- 執行時需有對應資料夾的讀取權限。

## 開發環境

- .NET Framework
- Windows Forms

---