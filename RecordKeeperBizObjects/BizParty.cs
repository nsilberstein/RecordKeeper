using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecordKeeperBizObjects
{
    public class BizParty : BizObject<BizParty>
    {
        string partynameval = "";
        string partycolorval = "";
        int yearestablishedval = 0;
        int presidentcountval = 0;
        List<BizPresident> lstpresident;
        public BizParty() 
        {
        }

       
    public int PartyId
        {
            get => this.PrimaryKeyValue;
            set => this.PrimaryKeyValue = value;
            
        }

        [Required]
        [Display(Name = "Party Name")]
        public string PartyName
        {
            get
            {
                return partynameval;
            }
            set
            {
                partynameval = value;
                InvokePropertyChanged();
            }
        }

        [Required]
        [Display(Name = "Year Established")]
        public int YearEstablished
        {
            get
            {
                return yearestablishedval;
            } 
            set
            {
                yearestablishedval = value;
                InvokePropertyChanged();
            }
        }

        public int PresidentCount
        {
            get
            {
                return presidentcountval;
            }
            set
            {
                presidentcountval = value;
                InvokePropertyChanged();
            }
        }

        [Required]
        [Display(Name = "Party Color")]
        public string PartyColor
        {
            get
            {
                return partycolorval;
            }
            set
            {
                partycolorval = value;
                InvokePropertyChanged();
            }
        }
        public List<BizPresident> PresidentList(bool refresh)
        {
            if (refresh == true || lstpresident == null)
            {
                return BizPresident.GetList("PartyName", this.PartyName);
            }
            return lstpresident;
        }
        
            
        }
    }

