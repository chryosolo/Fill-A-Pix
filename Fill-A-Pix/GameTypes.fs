﻿module Fill_A_Pix.GameTypes

open System.Drawing

// Primitive types
type BitmapFile = | BitmapFile of string
type WindowBitmap = | WindowBitmap of Bitmap
type BoardBitmap = | BoardBitmap of Bitmap
type Pixels = Color[,]
type PixelX = | PixelX of int
type PixelY = | PixelY of int
type CoordX = | CoordX of int
type CoordY = | CoordY of int
type PixelRect = {Top:PixelY; Bottom:PixelY; Left:PixelX; Right:PixelX}


type CellValue =
    | Init
    | Unknown
    | Filled
    | Blank

type ClueState =
    | Active
    | Used

type Clue =
    | Zero = 0
    | One = 1
    | Two = 2
    | Three = 3
    | Four = 4
    | Five = 5
    | Six = 6
    | Seven = 7
    | Eight = 8
    | Nine = 9

type CellClue = (Clue*ClueState) option

type Point = {X:int; Y:int}

type Cell = {Value:CellValue; Clue:CellClue; Point:Point}

type BoardState = {Rows:int; Cols:int; Cells:Cell[,]}

type UpdateBoardState = | UpdateCellValue of Cell*CellValue
                        | UpdateClueState of Cell*ClueState

