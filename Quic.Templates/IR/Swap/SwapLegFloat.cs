﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Quic.Templates
{
    using Quic.FPML;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class SwapLegFloat : SwapLeg
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 3 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
 
  // Run the base template:
  base.TransformText();

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 7 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"

protected override void GetMapType()
{

        
        #line default
        #line hidden
        
        #line 10 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write("\tstrType, S, CouponFloat\r\n");

        
        #line default
        #line hidden
        
        #line 12 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"

}
protected override void LegDetails()
{

        
        #line default
        #line hidden
        
        #line 16 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write("\tadtFixing, AD, ");

        
        #line default
        #line hidden
        
        #line 17 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(adtFixing));

        
        #line default
        #line hidden
        
        #line 17 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write("\r\n\tmpObservable, L, ");

        
        #line default
        #line hidden
        
        #line 18 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(mpObservable));

        
        #line default
        #line hidden
        
        #line 18 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write("\r\n");

        
        #line default
        #line hidden
        
        #line 19 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"

	if (!String.IsNullOrEmpty(arPastFixing))
	{

        
        #line default
        #line hidden
        
        #line 22 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write("\tarPastFixing, AR, ");

        
        #line default
        #line hidden
        
        #line 23 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(arPastFixing));

        
        #line default
        #line hidden
        
        #line 23 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write("\r\n");

        
        #line default
        #line hidden
        
        #line 24 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"

	}

        
        #line default
        #line hidden
        
        #line 26 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write("\tarLeverage, AR, ");

        
        #line default
        #line hidden
        
        #line 27 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(arLeverage));

        
        #line default
        #line hidden
        
        #line 27 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write("\r\n");

        
        #line default
        #line hidden
        
        #line 28 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"

	if (!String.IsNullOrEmpty(arSpread))
	{

        
        #line default
        #line hidden
        
        #line 31 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write("\tarSpread, AR, ");

        
        #line default
        #line hidden
        
        #line 32 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(arSpread));

        
        #line default
        #line hidden
        
        #line 32 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"
this.Write("\r\n");

        
        #line default
        #line hidden
        
        #line 33 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"

	}

        
        #line default
        #line hidden
        
        #line 36 "D:\QuIC\etl\code\Quic.WebService\Quic.Templates\IR\Swap\SwapLegFloat.tt"

}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
