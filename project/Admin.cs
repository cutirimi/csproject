﻿using System.Collections.Generic;

namespace project
{
    public class Admin
    {
        private int index;
        private Machine machine;
        private static Admin staticAdmin;
        public static Admin GetInstance()
        {
            if (staticAdmin == null)
            {
                staticAdmin = new Admin();
            }
            return staticAdmin;
        }

        public string AdminName { get; set; }     //관리자이름

        public string GetMachineType()
        {
            return machine.GetMachineType();
        }

        public void SetMachine(int index)
        {
            string machineState = FileUtil.GetMachineStateByIndex(index);
            if (machineState != null)
            {
                this.index = index;
                string[] machineInfo = machineState.Split(':');
                if (machineInfo[0] == "cold")
                {
                    this.machine = new ColdMachine();
                    if (machineInfo[1].Length != 0)
                    {
                        string[] items = machineInfo[1].Split('$');
                        for (int i = 0; i < items.Length; i++)
                        {
                            Item item = new ColdItem(items[i]);
                            this.machine.AddItem(item);
                        }
                    }


                }
                else if (machineInfo[0] == "hot")
                {
                    this.machine = new HotMachine();

                    if (machineInfo[1].Length != 0)
                    {
                        string[] items = machineInfo[1].Split('$');
                        for (int i = 0; i < items.Length; i++)
                        {
                            Item item = new ColdItem(items[i]);
                            this.machine.AddItem(item);
                        }
                    }
                }
            }
            else
            {

            }
        }
        public void AddItem(string item, string price, string stock)        //음료, 가격, 재고 추가
        {
            if (machine.GetMachineType() == "hot")      //뜨거운 자판기
            {
                HotItem hotItem = new HotItem(item, price, stock);
                machine.AddItem(hotItem);
            }

            else if (machine.GetMachineType() == "cold")        //차가운 자판기
            {
                ColdItem coldItem = new ColdItem(item, price, stock);
                machine.AddItem(coldItem);
            }
        }
        //public void RemoveItem(string item, string price, string stock)     //음료, 가격, 재고 삭제
        //{
        //    if (machine.GetMachineType() == "hot")      //뜨거운 자판기
        //    {
        //        HotItem hotItem = new HotItem(item, price, stock);
        //        machine.RemoveItem(hotItem);
        //    }

        //    else if (machine.GetMachineType() == "cold")        //차가운 자판기
        //    {
        //        ColdItem coldItem = new ColdItem(item, price, stock);
        //        machine.RemoveItem(coldItem);
        //    }

        //}
        public List<Item> GetItemList()
        {
            return machine.items;
        }

        public void SaveMachine()
        {
            FileUtil.StoreMachineStateByIndex(index, machine);
        }
    }
}
