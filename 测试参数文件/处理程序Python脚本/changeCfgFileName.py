import os
import sys
import xlwings as xw


def main():
    key = input('input tilt Value(0、+/-10、+/-20、+/-30、+/-40、+/-50、+/-60):')
    print(key)
    path = os.getcwd()
    files = os.listdir()
    for f in files:
        _, ext = os.path.splitext(f)
        if ext in ('.xls', '.xlsx'):
            # eg. "0.2g_0deg.xlsx"
            newf = f[:-9] + str(key) + 'deg.xlsx'
            run_xls(f, key, newf)
            os.rename(os.path.join(path,f),os.path.join(path,newf))
    print('all file update completely!')


def run_xls(xlsFile, key, newName):
    wb = xw.Book(xlsFile)
    ws = wb.sheets[0]
    ws.range('E6').value = key
    wb.save()
    wb.close()
    cmd = 'taskkill /IM EXCEL.exe'
    os.system(cmd)
    print(newName + ' update secussefully')


if __name__ == "__main__":
    main()
    input()
