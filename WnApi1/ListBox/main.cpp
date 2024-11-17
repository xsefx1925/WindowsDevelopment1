#define _CRT_SECURE_NO_WARNINGS
#include <windows.h>
#include "resource.h"
#include <stdio.h>


CONST CHAR* init_values[] = { "this", "is", "my", "first", "List", "Box" };

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nShowCmd)
{
    DialogBoxParam(hInstance, MAKEINTRESOURCE(IDC_LIST1), NULL, DlgProc, 0);
    return 0;
}

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
    switch (uMsg)
    {
    case WM_INITDIALOG:
    {
        HWND hList = GetDlgItem(hwnd, IDC_LIST1);
        for (int i = 0; i < sizeof(init_values) / sizeof(init_values[0]); i++)
        {
            SendMessage(hList, LB_ADDSTRING, 0, (LPARAM)init_values[i]);
        }
        break;
    }
    case WM_COMMAND:
        switch (LOWORD(wParam))
        {
        case IDOK:
        {
            HWND hList = GetDlgItem(hwnd, IDC_LIST1);
            CONST INT SIZE = 256;
            CHAR sz_buffer[SIZE] = {};
            CHAR sz_message[SIZE] = {};
            INT i = SendMessage(hList, LB_GETCURSEL, 0, 0);
            SendMessage(hList, LB_GETTEXT, i, (LPARAM)sz_buffer);
            sprintf(sz_message, "�� ������� ����� N%i �� ��������� \"%s\".", i, sz_buffer);
            MessageBox(hwnd, sz_message, "Selected value", MB_OK | MB_ICONINFORMATION);
            break;
        }
        case IDCANCEL:
            EndDialog(hwnd, 0);
            break;
        }
        break;
    case WM_CLOSE:
        EndDialog(hwnd, 0);
        break;
    default:
        return FALSE;
    }
    return TRUE;
}