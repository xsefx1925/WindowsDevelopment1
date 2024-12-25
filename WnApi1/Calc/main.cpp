﻿#define _CRT_SECURE_NO_WARNINGS
#include<Windows.h>
#include<cstdio>
#include<float.h>
#include"resource.h"
#include"Dimensions.h"	//размеры кнопок, и других элементов.....
#include"Skins.h"

//#define - определить
//показывает что заменить, чем заменить

//
/*
#define IDC_EDIT_DISPLAY  999
#define IDC_BUTTON_0      1000
#define IDC_BUTTON_1      1001
#define IDC_BUTTON_2      1002
#define IDC_BUTTON_3      1003
#define IDC_BUTTON_4      1004
#define IDC_BUTTON_5      1005
#define IDC_BUTTON_6      1006
#define IDC_BUTTON_7      1007
#define IDC_BUTTON_8      1008
#define IDC_BUTTON_9      1009
#define IDC_BUTTON_POINT  1010

#define IDC_BUTTON_PLUS   1011
#define IDC_BUTTON_MINUS  1012
#define IDC_BUTTON_ASTER  1013 //"*"
#define IDC_BUTTON_SLASH  1014//  /

#define IDC_BUTTON_BSP    1015 //Backspase
#define IDC_BUTTON_CLR    1016 //clear
#define IDC_BUTTON_EQUAL  1017 //"="




CONST INT g_i_BUTTON_SIZE = 50; //ðàçìåð êíîïêè â ïèêñåëÿõ
CONST INT g_i_INTERVAL = 5; //ðàññòîÿíèå ìåæäó êíîïêàìè
CONST INT g_i_BUTTON_DOUBLE_SIZE = g_i_BUTTON_SIZE * 2 + g_i_INTERVAL;

CONST INT g_i_SCREEN_WIDTH = g_i_BUTTON_SIZE *5 + g_i_INTERVAL * 4;
CONST INT g_i_SCREEN_HEIGHT = 22;


CONST INT g_i_START_X = 10;
CONST INT g_i_START_Y = 10;
CONST INT g_i_BUTTON_START_X = g_i_START_X;
CONST INT g_i_BUTTON_START_Y = g_i_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL;

#define BUTTON_SHIFT_X(column) g_i_BUTTON_START_X + (g_i_BUTTON_SIZE + g_i_INTERVAL)*(column)
#define BUTTON_SHIFT_Y(row)    g_i_BUTTON_START_Y + (g_i_BUTTON_SIZE + g_i_INTERVAL)*(row)

CONST INT g_i_WINDOW_WIDTH = g_i_SCREEN_WIDTH + g_i_START_X * 2;
CONST INT g_i_WINDOW_HEIGHT = g_i_START_X + g_i_SCREEN_HEIGHT + g_i_BUTTON_SIZE * 4 + g_i_INTERVAL * 5;
*/

CONST CHAR g_sz_WINDOW_CLASS[] = "Calc_WPD_311";//класс окна
CONST CHAR* g_OPERATIONS[] = { "+","-", "*",  "/" }; //для того чтобы быстрее добавлять кнопки операций

//'+';-символьная константа
//"+";строковая константа
//строка это массив, а массив это указатель поскольку имя массива содержит адрес нулевого элемента массива

INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
INT GetTitleBarHeight(HWND hwnd);
VOID SetSkin(HWND hwnd, CONST CHAR skin[]);
VOID SetSkinFromDLL(HWND hwnd, CONST CHAR skin[]);


INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	//hInstance - экзмпляр исполняемого файла программы загруженной в память
	//hPrevInst - не используется
	//lpCmdLine - коммандная строка с которой запустилась программа
	//nCmdShow - режим отображения окна (свернуто на панель задач, развернуто на весь экран, свернуто в окно)

	//HINSTANCE - тип данных
	//hInstance - имя переменной

	float a = -34.01;
	float b = 8.3;
	//1) регистрация класса окна:
	WNDCLASSEX wClass;
	ZeroMemory(&wClass, sizeof(wClass));

	wClass.style = 0;
	wClass.cbSize = sizeof(wClass);
	wClass.cbClsExtra = 0;
	wClass.cbWndExtra = 0;

	wClass.hIcon = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_ICON1));
	wClass.hIconSm = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_ICON1));
	wClass.hCursor = LoadCursor(hInstance, MAKEINTRESOURCE(IDC_ARROW));
	wClass.hbrBackground = (HBRUSH)COLOR_WINDOW;

	wClass.hInstance = hInstance;
	wClass.lpszClassName = g_sz_WINDOW_CLASS;
	wClass.lpszMenuName = NULL;
	wClass.lpfnWndProc = (WNDPROC)WndProc;

	if (!RegisterClassEx(&wClass))
	{
		MessageBox(NULL, "Class registration failed", NULL, MB_OK | MB_ICONERROR);
		return 0;
	}
	//2) создание окна:
	HWND hwnd = CreateWindowEx
	(
		NULL,
		g_sz_WINDOW_CLASS,
		g_sz_WINDOW_CLASS,
		WS_OVERLAPPEDWINDOW ^ WS_THICKFRAME ^ WS_MAXIMIZEBOX,
		
		CW_USEDEFAULT, CW_USEDEFAULT,
		g_i_WINDOW_WIDTH + 16, g_i_WINDOW_HEIGHT + 42,
		NULL,
		NULL,
		hInstance,
		NULL
	);
	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);
	//3) запуск цикла сообщений:
	MSG msg;
	while (GetMessage(&msg, NULL, 0, 0) > 0)
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return msg.wParam;
}

INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	//процедура окна это самая обычная функция, которая неявно вызывается при запуске окна. 
	//процедура окна всегда принимает 4 параметра: 
	//hwnd - окно; 
	//uMsg	 - сообщение;
	//wParam, lParam - параметры сообщения, зависят от сообщения. Максимум в функцию можно передать 4 параметра сообщения, 
	//поскольку wParam и lParam делятся на LOWORD(младшее слово) и HIWORD(старшее слово)

	static INT index = 0; // выбирает скин и цветовую схему из массивов: 
	//g_SKIN[];
	//g_WINDOW_BACKGROUND_COLOR[] ;
	//g_DISPLAY_BACKGROUND_COLOR[};
	//g_DISPLAY_FOREGROUND_COLOR[];
	switch (uMsg)// это основной switch процедуры окна, он выбирает различные действия в зависимости от сообщения, когда пользователь нажимает на кнопки,
		//обрабатывается сообщение WM_COMMAND  
	{
	case WM_CREATE:	//в этой секции создаются элементы окна
	{
		HWND hEdit = CreateWindowEx
		(
			NULL, "Edit", "0",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_RIGHT,
			10, 10,
			g_i_SCREEN_WIDTH, g_i_SCREEN_HEIGHT,
			hwnd,
			(HMENU)999,
			GetModuleHandle(NULL),
			NULL
		);
		 AddFontResource("Fonts\\MOSCOW2024.otf");
		 HFONT hFont = CreateFont
		 (
			 g_i_FONT_HEIGHT, g_i_FONT_WIDTH,
			 0, 0,
			 FW_MEDIUM, 0, 0, 0,//Bold, Italic, UnderLine, Strikeout
			 ANSI_CHARSET,
			 OUT_CHARACTER_PRECIS,
			 CLIP_CHARACTER_PRECIS,
			 ANTIALIASED_QUALITY,
			 FF_DONTCARE,
			 "MOSCOW2024"
		 );
		 SendMessage(hEdit, WM_SETFONT, (WPARAM)hFont, TRUE);
		CHAR sz_digit[2] = {};
		for (int i = 6; i >= 0; i -= 3)
		{
			for (int j = 0; j < 3; j++)
			{
				sz_digit[0] = i + j + '1';
				CreateWindowEx
				(
					NULL, "Button", sz_digit,
					//WS_CHILD | WS_VISIBLE,
					WS_CHILD | WS_VISIBLE | BS_BITMAP,
					g_i_BUTTON_START_X + (g_i_BUTTON_SIZE + g_i_INTERVAL) * j,
					g_i_BUTTON_START_Y + (g_i_BUTTON_SIZE + g_i_INTERVAL) * (2 - i / 3),
					g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
					hwnd,
					(HMENU)(IDC_BUTTON_1 + i + j),
					GetModuleHandle(NULL),
					NULL
				);

			}

		}
		//добавить стиль BS_BITMAP:
		HWND hButton_0 = CreateWindowEx
		(
			NULL, "Button", "0",
			WS_CHILD | WS_VISIBLE | BS_BITMAP,
			BUTTON_SHIFT_X(0), BUTTON_SHIFT_Y(3),
			
			g_i_BUTTON_DOUBLE_SIZE, g_i_BUTTON_SIZE,
			hwnd,
			(HMENU)IDC_BUTTON_0,
			GetModuleHandle(NULL),
			NULL
		);
		//2)загрузить картинку из файла:
		/*
		HBITMAP bmpButton_0 = (HBITMAP)LoadImage
		(
			NULL,
			"ButtonsBMP\\button_0.bmp",
			IMAGE_BITMAP,
			g_i_BUTTON_DOUBLE_SIZE,
			g_i_BUTTON_SIZE,
			LR_LOADFROMFILE
		);
		//3)Установить картинку на кнопку:
		SendMessage(hButton_0, BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)bmpButton_0);
		*/
		//HBITMAP bmpButton_0 = (HBITMAP)LoadImage
		//(
		//	NULL, 
		//	"ButtonsBMP\\button_0.bmp", 
		//	IMAGE_BITMAP, 
		//	g_i_BUTTON_DOUBLE_SIZE, g_i_BUTTON_SIZE, 
		//	LR_LOADFROMFILE
		//);
		////3) Установить картинку на кнопку:
		//SendMessage(hButton_0, BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)bmpButton_0);

		CreateWindowEx
		(
			NULL, "Button", ".",
			WS_CHILD | WS_VISIBLE | BS_BITMAP,
			BUTTON_SHIFT_X(2), BUTTON_SHIFT_Y(3),
			
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd,
			(HMENU)IDC_BUTTON_POINT,
			GetModuleHandle(NULL),
			NULL
		);
		for (int i = 0; i < 4; i++)
		{
			CreateWindowEx
			(
				NULL, "Button", g_OPERATIONS[i],
				WS_CHILD | WS_VISIBLE | BS_BITMAP,
				BUTTON_SHIFT_X(3), BUTTON_SHIFT_Y(3 - i),
				
				g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
				hwnd,
				(HMENU)(IDC_BUTTON_PLUS + i),
				GetModuleHandle(NULL),
				NULL
			);
		}
		CreateWindowEx
		(
			NULL, "Button", "<-",
			WS_CHILD | WS_VISIBLE | BS_BITMAP,
			BUTTON_SHIFT_X(4), BUTTON_SHIFT_Y(0),
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd,
			(HMENU)IDC_BUTTON_BSP,
			GetModuleHandle(NULL),
			NULL
		);

		CreateWindowEx
		(
			NULL, "Button", "C",
			WS_CHILD | WS_VISIBLE | BS_BITMAP,
			BUTTON_SHIFT_X(4), BUTTON_SHIFT_Y(1),
			g_i_BUTTON_SIZE, g_i_BUTTON_SIZE,
			hwnd,
			(HMENU)IDC_BUTTON_CLR,
			GetModuleHandle(NULL),
			NULL
		);
		CreateWindowEx
		(
			NULL, "Button", "=",
			WS_CHILD | WS_VISIBLE | BS_BITMAP,
			BUTTON_SHIFT_X(4), BUTTON_SHIFT_Y(2),
			g_i_BUTTON_SIZE, g_i_BUTTON_DOUBLE_SIZE,
			hwnd,
			(HMENU)IDC_BUTTON_EQUAL,
			GetModuleHandle(NULL),
			NULL
		);
		//	INT title_bar_height = GetTitleBarHeight(hwnd);
		SetSkinFromDLL(hwnd, "square_blue.dll");
	}
	break;
	case WM_CTLCOLOREDIT:	// эта секция обычно задает цвет фона и текста в текстовом поле, но у нас она также задает цвет главного окна
	{
		HDC hdcEdit = (HDC)wParam;
	//	SetBkMode(hdcEdit, OPAQUE);
		SetBkColor(hdcEdit, g_DISPLAY_BACKGROUND_COLOR[index]);
		SetTextColor(hdcEdit, g_DISPLAY_FOREGROUND_COLOR[index]);

		HBRUSH hbrBackground = CreateSolidBrush(g_WINDOW_BACKGROUND_COLOR[index]);

		SetClassLongPtr(hwnd, GCLP_HBRBACKGROUND, (LONG)hbrBackground );	//задаем цвет главного окна
		SendMessage(hwnd, WM_ERASEBKGND, wParam, 0);
		//InvalidateRect(hwnd, NULL, TRUE);
		//UpdateWindow(hwnd);
		//SetSkin(hwnd, g_SKIN[index]);
		
		RedrawWindow(hwnd, NULL, NULL, RDW_ERASE );//перерисовать окно
		return (LRESULT)hbrBackground;
	}
		break;
	case WM_COMMAND:// это сообщение приходит когда пользователь нажимает ЛКМ  на элементы окна
	{
		static DOUBLE  a = DBL_MIN;
		static DOUBLE  b = DBL_MIN;
		static WORD operation = 0;
		static BOOL input = FALSE;
		static BOOL operation_input = FALSE;
		static BOOL equal_pressed = FALSE;
		SetFocus(hwnd);//Для того чтобы всегда работала клавиатура
		HWND hEditDisplay = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
		CONST INT SIZE = 256;
		CHAR sz_display[SIZE]{};
		CHAR  sz_digit[2]{};
		if (LOWORD(wParam) >= IDC_BUTTON_0 && LOWORD(wParam) <= IDC_BUTTON_9)
		{
			if (operation_input || equal_pressed)
			{
				SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)""),
					operation_input = equal_pressed = FALSE;
			}
			sz_digit[0] = LOWORD(wParam) - IDC_BUTTON_0 + '0';
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (strlen(sz_display) == 1 && sz_display[0] == '0')
				sz_display[0] = sz_digit[0];
			else
				strcat(sz_display, sz_digit);
			SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
			input = TRUE;
		}
		if (LOWORD(wParam) == IDC_BUTTON_POINT)
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (strchr(sz_display, '.'))break;
			strcat(sz_display, ".");
			SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
		}
		if (LOWORD(wParam) == IDC_BUTTON_BSP)
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (strlen(sz_display) > 1)
				sz_display[strlen(sz_display) - 1] = 0;
			else
				sz_display[0] = '0';
			SendMessage(hEditDisplay, WM_GETTEXT, 0, (LPARAM)sz_display);
		}
		if (LOWORD(wParam) == IDC_BUTTON_CLR)
		{
			a = b = DBL_MIN;
			operation = 0;
			input = operation_input = FALSE;
			SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)"0");
		}
		/////////////////////////////////////////////////////////////////////////
		if (LOWORD(wParam) >= IDC_BUTTON_PLUS && LOWORD(wParam) <= IDC_BUTTON_SLASH)
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (input && a == DBL_MIN)a = atof(sz_display);
			//input = FALSE;
			if (operation && input)
				SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_EQUAL), 0);
			operation = LOWORD(wParam);
			operation_input = TRUE;
			equal_pressed = FALSE;
		}
		if (LOWORD(wParam) == IDC_BUTTON_EQUAL)
		{
			SendMessage(hEditDisplay, WM_GETTEXT, SIZE, (LPARAM)sz_display);
			if (input)b = atof(sz_display);
			input = FALSE;
			switch (operation)
			{
			case IDC_BUTTON_PLUS: a += b; break;
			case IDC_BUTTON_MINUS: a -= b; break;
			case IDC_BUTTON_ASTER: a *= b; break;
			case IDC_BUTTON_SLASH: a /= b; break;
			}
			operation_input = FALSE;
			equal_pressed = TRUE;
			sprintf(sz_display, "%g", a);
			SendMessage(hEditDisplay, WM_SETTEXT, 0, (LPARAM)sz_display);
		}
	}
	break;

	case WM_KEYDOWN://это сообщение приходит когда пользователь нажимает клавишу
	{
		if (GetKeyState(VK_SHIFT) < 0 && wParam == 0x38)
		{
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_ASTER), BM_SETSTATE, TRUE, 0);
		}
		else if (wParam >= '0' && wParam <= '9')
		{
			SendMessage(GetDlgItem(hwnd, wParam - '0' + IDC_BUTTON_0), BM_SETSTATE, TRUE, 0);

		}
		else if (wParam >= 0x60 && wParam <= 0x69)
		{
			SendMessage(GetDlgItem(hwnd, wParam - 0x60 + IDC_BUTTON_0), BM_SETSTATE, TRUE, 0);
			//SendMessage(hwnd, WM_COMMAND, LOWORD(wParam - 0 * 60 + IDC_BUTTON_0), 0);
		}
		switch (wParam)
		{
		case VK_OEM_PLUS:
		case VK_ADD:

			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_PLUS), BM_SETSTATE, TRUE, 0);
			break;
		case VK_OEM_MINUS:
		case VK_SUBTRACT:

			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_MINUS), BM_SETSTATE, TRUE, 0);
			break;
		case VK_MULTIPLY:

			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_ASTER), BM_SETSTATE, TRUE, 0);
			break;
		case VK_OEM_2:
		case VK_DIVIDE:

			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_SLASH), BM_SETSTATE, TRUE, 0);
			break;

		case VK_OEM_PERIOD:
		case VK_DECIMAL:

			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_POINT), BM_SETSTATE, TRUE, 0);
			break;

		case VK_BACK:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_BSP), BM_SETSTATE, TRUE, 0);
			break;

		case VK_ESCAPE:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_CLR), BM_SETSTATE, TRUE, 0);
			break;

		case VK_RETURN:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_EQUAL), BM_SETSTATE, TRUE, 0);
			break;
		}
	}
	break;

	case WM_KEYUP:	//это сообщение приходит когда юзер отжимает клавишу
	{
		if (GetKeyState(VK_SHIFT) < 0 && wParam == 0x38)
		{
			SendMessage(hwnd, WM_COMMAND, IDC_BUTTON_ASTER, 0);
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_ASTER), BM_SETSTATE, FALSE, 0);

		}
		else if (wParam >= '0' && wParam <= '9')
		{
			SendMessage(hwnd, WM_COMMAND, LOWORD(wParam - '0' + IDC_BUTTON_0), 0);
			SendMessage(GetDlgItem(hwnd, wParam - '0' + IDC_BUTTON_0), BM_SETSTATE, FALSE, 0);
		}
		else if (wParam >= 0x60 && wParam <= 0x69)
		{
			SendMessage(hwnd, WM_COMMAND, LOWORD(wParam - 0x60 + IDC_BUTTON_0), 0);
			SendMessage(GetDlgItem(hwnd, wParam - 0x60 + IDC_BUTTON_0), BM_SETSTATE, FALSE, 0);
		}
		switch (wParam)
		{
		case VK_OEM_PLUS:
		case	VK_ADD:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_PLUS), BM_SETSTATE, FALSE, 0);
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_PLUS), 0);
			break;

		case VK_OEM_MINUS:
		case	VK_SUBTRACT:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_MINUS), BM_SETSTATE, FALSE, 0);
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_MINUS), 0);
			break;

		case VK_MULTIPLY:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_ASTER), BM_SETSTATE, FALSE, 0);
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_ASTER), 0);
			break;

		case VK_OEM_2:
		case VK_DIVIDE:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_SLASH), BM_SETSTATE, FALSE, 0);
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_SLASH), 0);
			break;

		case VK_OEM_PERIOD:
		case VK_DECIMAL:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_POINT), BM_SETSTATE, FALSE, 0);
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_POINT), 0);
			break;

		case VK_BACK:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_BSP), BM_SETSTATE, FALSE, 0);
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_BSP), 0);
			break;

		case VK_ESCAPE:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_CLR), BM_SETSTATE, FALSE, 0);
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_CLR), 0);
			break;

		case VK_RETURN:
			SendMessage(GetDlgItem(hwnd, IDC_BUTTON_EQUAL), BM_SETSTATE, FALSE, 0);
			SendMessage(hwnd, WM_COMMAND, LOWORD(IDC_BUTTON_EQUAL), 0);
			break;
		}
	}
	break;
	case WM_CONTEXTMENU://это сообщение приходит когда юзер нажимает ПКМ на окно
	{
		//1)создаем всплывающее меню
		HMENU hMenu = CreatePopupMenu();
		//2)добавляем пункты в созданное меню:
		InsertMenu(hMenu, 0, MF_BYPOSITION | MF_STRING, IDR_EXIT, "Exit");
		InsertMenu(hMenu, 0, MF_BYPOSITION | MF_SEPARATOR, 0, NULL);
		InsertMenu(hMenu, 0, MF_BYPOSITION | MF_STRING | MF_UNCHECKED, IDR_METAL_MISTRAL, "Metal Mistral");
		InsertMenu(hMenu, 0, MF_BYPOSITION | MF_STRING | MF_UNCHECKED, IDR_SQUARE_BLUE, "Square blue");
		CheckMenuItem(hMenu, index, MF_BYPOSITION | MF_CHECKED);
		//3)использование контекстного меню:
		DWORD item = TrackPopupMenu(hMenu, TPM_RETURNCMD | TPM_RIGHTALIGN | TPM_BOTTOMALIGN, LOWORD(lParam), HIWORD(lParam), 0, hwnd, NULL);
		switch (item)
		{
		case IDR_SQUARE_BLUE:// SetSkin(hwnd, "square_blue"); break;
		case IDR_METAL_MISTRAL: //SetSkin(hwnd, "metal_mistral"); break;
			index = item - IDR_SQUARE_BLUE;
			//SendMessage(GetDlgItem(hwnd, item), )
		//	ModifyMenu(hMenu, item - IDR_SQUARE_BLUE, MF_BYPOSITION | MF_STRING | MF_CHECKED, item, NULL);
			break;
		case IDR_EXIT: SendMessage(hwnd, WM_CLOSE, 0, 0); break;
		}
		HWND hEditDisplay = GetDlgItem(hwnd, IDC_EDIT_DISPLAY);
		HDC hdcDisplay = GetDC(hEditDisplay);
		SendMessage(hwnd, WM_CTLCOLOREDIT, (WPARAM)hdcDisplay, 0);
		ReleaseDC(hEditDisplay, hdcDisplay);
		SetSkinFromDLL(hwnd, g_SKIN[index]);
		//SetFocus(hEditDisplay);
		//SendMessage(hwnd, WM_CTLCOLOREDIT, )

		//4)удаляем меню:
		DestroyMenu(hMenu);

	}
	break;
	case WM_DESTROY:// это сообщение уничтожает окно
		PostQuitMessage(0);
		break;
	case WM_CLOSE:// это сообщение закрывает окно, здесь просто отправляется сообщение на уничтожение окна
		DestroyWindow(hwnd);
		break;
	default: return DefWindowProc(hwnd, uMsg, wParam, lParam);
	}
	return FALSE;
}

INT GetTitleBarHeight(HWND hwnd)
{
	RECT window_rect;
	RECT client_rect;
	GetWindowRect(hwnd, &window_rect);
	GetClientRect(hwnd, &client_rect);
	INT title_bar_height = (window_rect.bottom - window_rect.top) - (client_rect.bottom - client_rect.top);
	return title_bar_height;
}


CONST CHAR* g_BUTTONS[] =
{
	"button_0.bmp",
	"button_1.bmp",
	"button_2.bmp",
	"button_3.bmp",
	"button_4.bmp",
	"button_5.bmp",
	"button_6.bmp",
	"button_7.bmp",
	"button_8.bmp",
	"button_9.bmp",
	"button_point.bmp",
	"button_plus.bmp",
	"button_minus.bmp",
	"button_aster.bmp",
	"button_slash.bmp",
	"button_bsp.bmp",
	"button_clr.bmp",
	"button_equal.bmp"
};

VOID SetSkin(HWND hwnd, CONST CHAR skin[])
{
	CHAR sz_filename[MAX_PATH]{};
	for (int i = IDC_BUTTON_0; i <= IDC_BUTTON_EQUAL; i++)
	{
		HWND hButton = GetDlgItem(hwnd, i);
		sprintf(sz_filename, "ButtonsBMP\\%s\\%s", skin, g_BUTTONS[i - IDC_BUTTON_0]);
		HBITMAP bmpButton = (HBITMAP)LoadImage
		(
			NULL,
			sz_filename,
			IMAGE_BITMAP,
			i == IDC_BUTTON_0 ? g_i_BUTTON_DOUBLE_SIZE : g_i_BUTTON_SIZE,
			i == IDC_BUTTON_EQUAL ? g_i_BUTTON_DOUBLE_SIZE : g_i_BUTTON_SIZE,
			LR_LOADFROMFILE
		);
		SendMessage(hButton, BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)bmpButton);
	}
}
VOID SetSkinFromDLL(HWND hwnd, CONST CHAR skin[])
{
	HMODULE hModule = LoadLibrary(skin);
	for (int i = IDC_BUTTON_0; i <= IDC_BUTTON_EQUAL; i++)
	{
		HWND hButton = GetDlgItem(hwnd, i);
		HBITMAP bmpButton = (HBITMAP)LoadImage
		(
			hModule,
			MAKEINTRESOURCE(i),
			IMAGE_BITMAP,
			i == IDC_BUTTON_0 ? g_i_BUTTON_DOUBLE_SIZE : g_i_BUTTON_SIZE,
			i == IDC_BUTTON_EQUAL ? g_i_BUTTON_DOUBLE_SIZE : g_i_BUTTON_SIZE,
			LR_SHARED//с NULL тоже работает
		);
		SendMessage(hButton, BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)bmpButton);
	}
	FreeLibrary(hModule);
}