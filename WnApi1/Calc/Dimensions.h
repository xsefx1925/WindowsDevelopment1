﻿#pragma once
#include<Windows.h>

CONST INT g_i_BUTTON_SIZE = 50;	//ðàçìåð êíîïêè â ïèêñåëàõ
CONST INT g_i_INTERVAL = 5;		//ðàññòîÿíèå ìåæäó êíîïêàìè
CONST INT g_i_BUTTON_DOUBLE_SIZE = g_i_BUTTON_SIZE * 2 + g_i_INTERVAL;	//ðàçìåð êíîïêè â ïèêñåëàõ

CONST INT g_i_SCREEN_WIDTH = g_i_BUTTON_SIZE * 5 + g_i_INTERVAL * 4;
CONST INT g_i_SCREEN_HEIGHT = 48;
CONST INT g_i_FONT_HEIGHT = g_i_SCREEN_HEIGHT - 2;
CONST INT g_i_FONT_WIDTH = g_i_FONT_HEIGHT / 2;

CONST INT g_i_START_X = 10;
CONST INT g_i_START_Y = 10;
CONST INT g_i_BUTTON_START_X = g_i_START_X;
CONST INT g_i_BUTTON_START_Y = g_i_START_Y + g_i_SCREEN_HEIGHT + g_i_INTERVAL;

#define BUTTON_SHIFT_X(column)	g_i_BUTTON_START_X + (g_i_BUTTON_SIZE + g_i_INTERVAL)*(column)
#define BUTTON_SHIFT_Y(row)		g_i_BUTTON_START_Y + (g_i_BUTTON_SIZE + g_i_INTERVAL)*(row)

CONST INT g_i_WINDOW_WIDTH = g_i_SCREEN_WIDTH + g_i_START_X * 2;
CONST INT g_i_WINDOW_HEIGHT = g_i_START_X + g_i_SCREEN_HEIGHT + g_i_BUTTON_SIZE * 4 + g_i_INTERVAL * 5;


/*
#pragma once
#include<Windows.h>

CONST INT g_i_BUTTON_SIZE = 50; //размер кнопки в пикселях
CONST INT g_i_INTERVAL = 5; //расстояние между кнопками
CONST INT g_i_BUTTON_DOUBLE_SIZE = g_i_BUTTON_SIZE * 2 + g_i_INTERVAL;

CONST INT g_i_SCREEN_WIDTH = g_i_BUTTON_SIZE * 5 + g_i_INTERVAL * 4;
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