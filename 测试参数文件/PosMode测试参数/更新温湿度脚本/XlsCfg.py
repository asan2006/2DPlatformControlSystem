import sys
import os
import xlwings as xw

PATHFILES = "文件路径.txt"
T_RH_FILE = "温湿度信息.txt"
N = 0


def readNew_T_RH():
    f = open(T_RH_FILE)
    newInfo = f.read()
    f.close()
    return newInfo

def UpdateXlsCfg_T_RH(xlsFile):
    
    print("正在更新第{0}个配置文件：{1}".format(N,xlsFile))
    wb = xw.Book(xlsFile)
    ws = wb.sheets[0]
    #更新最后一行温湿度信息
    newInfo = readNew_T_RH().splitlines()
    #更新保存配置文件
    ws.range('D25').value = newInfo[0]
    ws.range('D26').value = newInfo[1]
    wb.save()
    wb.close()
    # 杀进程
    cmd = 'taskkill /IM EXCEL.exe'
    os.system(cmd)
    print("更新第{0}个成功：{1}".format(N,xlsFile))

def main():
    global N
    #读取文件夹路径
    filePaths = []
    for line in open("文件路径.txt"):
        filePaths.append(line.strip("\n"))
        #print(filePaths)

    #读取每一个配置文件
    for path in filePaths:    
        listFile = os.listdir(path)
        for file in listFile:
            if os.path.isfile(path + "\\" + file):
                # 判断是xls类型的配置文件
                if os.path.splitext(file)[1] in [".xlsx",".xls"]:
                    N = N + 1
                    UpdateXlsCfg_T_RH(path + "\\" + file)

if __name__ == "__main__":
    main()
    print("更新完毕，按回车键退出...")
    input()

