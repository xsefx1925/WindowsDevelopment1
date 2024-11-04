#include<Windows.h>
#include"resource.h"
//#define MESSAGE_BOX

BOOL CALLBACK  DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrewInst, LPSTR IpCmdLine, INT nCmdShow)
{
	/*
	WinMain ������ ��������� 4 ���������
	hInstance - ��������� ������ ���������� � ������ (��������� *. exe-�����)
	hPrevInst - ���������� ���������� ��������� (Deprecated, ������������� � Windows 98). ����� ����� �� �������������
	LPSTR lpCmdLine:
	LPSTR LongPointer to String (��������� �� ������ ��������� const char*) 
	lpCmdLine - ���������� ������ ������� ����������
	nCmdShow - ����� ����������� ����: �������� � ����, ���������� �� ���� �����, �������� �� ������ �����
	------------------------------------------------------------------------------------------------------
	*/
	
#ifdef MESSAGE_BOX
	MessageBox(
		NULL,
		"Hello WinApi!\n��� ���� ���������",
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
	��������� ���� (DlgProg) - ��������� ���� - ��� ����� ������� �������, ������� ������ ����������
	��� ����� ��������� � ������������� ����.
	����� ��������� ���� ������ ��������� 4 ���������
	DlgProg(WndProg) - ��������� ����.
	��������� - ��� �������
	��������� ���� ������ ��������� 4 ���������
	hwnd {Handler to Window) - ����. ���������� ���� - ��� �����, ����� ������� ����� ���������� � ����
	--------------------------------------------------------------------------------------------------
	uMsg - ���������, ������������ ����
	-----------------------------------
	wParam, lParam - ��������� ���������. ��� �������������� ����������, ����������� � ���� ������ � ����������, �������� 
	� ���������� WM_COMMAND, wParam ������ �������� �������� ������� ����, ������� ������������ ��������� WM_COMMAND
	WPARAM � LPARAM ������������ ����� ������������� �������� ���� int(DWORD - Double Word)
	�� ��� ������� ��������� �� HIWORD (������� �����) � LOWORD (������� �����)
	����� (WORD) - ��� 2 �����
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
		case IDOK: MessageBox(hwnd, "���� ������ ������ ��", "Info", MB_OK | MB_ICONINFORMATION); break;
		case IDCANCEL: EndDialog(hwnd, 0); break;
		}
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
		break;
		
	}
	return FALSE;
}
