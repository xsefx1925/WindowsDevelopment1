#include<Windows.h>
#include"resource.h"
//#define MESSAGE_BOX

BOOL CALLBACK  DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrewInst, LPSTR IpCmdLine, INT nCmdShow)
{
	/*
	WinMain всегда принимает 4 параметра
	hInstance - экземпляр нашего приложения в памяти (экземпляр *. exe-файла)
	hPrevInst - предыдущий запущенный экземпляр (Deprecated, использовался в Windows 98). после этого не использовался
	LPSTR lpCmdLine:
	LPSTR LongPointer to String (Указатель на строку наподобие const char*) 
	lpCmdLine - коммандная строка запуска приложения
	nCmdShow - режим отображения окна: Свернуто в окно, Развернуто на весь экран, свернуто на панель задач
	------------------------------------------------------------------------------------------------------
	*/
	
#ifdef MESSAGE_BOX
	MessageBox(
		NULL,
		"Hello WinApi!\nЭто окно сообщения",
		"Question",
		MB_YESNOCANCEL | MB_ICONQUESTION
		|MB_HELP | MB_DEFBUTTON4
		|MB_SYSTEMMODAL
	);
#endif // MESSAGE_BOX
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, DlgProc, 0);
	return 0;
}
BOOL CALLBACK  DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
/*
	Процедура окна (DlgProg) - процедура окна - это самая обычная функция, которая неявно вызывается
	при любом обращении к определенному окну.
	Любая процедура окна всегда принимает 4 параметра
	DlgProg(WndProg) - Процедура окна.
	процедура - это функция
	процедура окна всегда принимает 4 параметра
	hwnd {Handler to Window) - окна. Обработчик окна - это число, через которое можно обратиться к окну
	--------------------------------------------------------------------------------------------------
	uMsg - сообщение, отправляемое окну
	-----------------------------------
	wParam, lParam - параметры сообщения. это сопровождающая информация, поступающая в окно вместе с сообщением, например 
	с сообщением WM_COMMAND, wParam всегда приходит дочерний элемент окна, который сгенерировал сообщение WM_COMMAND
	WPARAM и LPARAM представляют собой целочисленные значения типа int(DWORD - Double Word)
	Их как правило разделяют на HIWORD (старшее слово) и LOWORD (младшее слово)
	Слово (WORD) - это 2 байта
	-------------------------------------------------------------------------------
	BYTE = 8 bit;
	WORD = 2 byte (16 bit);
	DWORD (Double Word) = 4 byte = 32 bit;
	QWORD (Quad Word) = 8 byte (64 bit);
	TBYTE (Double Quad Word) = 10 Byte (80 bit);
	DQWORD (Double Quad Word) = 16 Byte (128 bit);
	------------------------------------------------------------------------------------


	*/
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		HICON hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON1));
		SendMessage(hwnd, WM_SETICON, 0, (LPARAM)hIcon);
	}
		break;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case IDOK: MessageBox(hwnd, "Была нажата кнопка ОК", "Info", MB_OK | MB_ICONINFORMATION); break;
		case IDCANCEL: EndDialog(hwnd, 0); break;
		}
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
		break;
		
	}
	return FALSE;
}
