using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PcPartsMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcPartsMarket.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.PcComponents.Any())
            {
                context.AddRange
                (
                    new PcComponent
                    {
                        Name = "FlexScan EV3285",
                        Brand ="Eizo",
                        Price = 1350m,
                        ShortDescription = "31.5”, 4K professional Eizo monitor.",
                        LongDescription = "31.5-inch, 4K UHD (3840 x 2160) resolution monitor that gives you four times the workspace of full HD. And, work four times better with the EV3285’s four-sided frameless and fully flat design.",
                        InfoLink = "https://www.eizo.com/products/flexscan/ev3285",
                        Category = Categories["Monitor"],
                        ImageUrl = @"/images/articles/Eizo_EV3285_la.jpg",
                        InStock = true,
                        IsPreferredPcComponent = true,
                        ImageThumbnailUrl = @"/images/articles/Eizo_EV3285_sm.jpg"

                    },
                    new PcComponent
                    {
                        Name = "UltraSharp U2715H",
                        Brand = "Dell",
                        Price = 514m,
                        ShortDescription = "27”, 2K Dell UltraSharp monitor.",
                        LongDescription = "Enjoy 68.5cm(27”) of superb screen clarity on a sharp QHD 2560 x 1440 resolution monitor. Plus, you get great color consistency across an ultra - wide 178°/ 178° viewing angle.",
                        InfoLink = "https://www.dell.com/en-us/work/shop/cty/monitor-dell-ultrasharp-27-u2715h/spd/dell-u2715h",
                        Category = Categories["Monitor"],
                        ImageUrl = @"/images/articles/Dell_U2715H_la.jpg",
                        InStock = true,
                        IsPreferredPcComponent = true,
                        ImageThumbnailUrl = @"/images/articles/Dell_U2715H_sm.jpg"
                    },
                    new PcComponent
                    {
                        Name = "i7-8700K",
                        Brand = "Intel",
                        Price = 405.60m,
                        ShortDescription = "Intel® Core™ i7 Processor.",
                        LongDescription = "8th Generation Intel® Core™ i7 Processors with 6 Cores, 12 Threads, 4.70 GHz Max Turbo Frequency, integrated Intel® UHD Graphics 630, socket FCLGA1151.",
                        InfoLink = "https://ark.intel.com/content/www/us/en/ark/products/126684/intel-core-i7-8700k-processor-12m-cache-up-to-4-70-ghz.html",
                        Category = Categories["CPU"],
                        ImageUrl = @"/images/articles/8700k_sm.jpg",
                        InStock = true,
                        IsPreferredPcComponent = true,
                        ImageThumbnailUrl = @"/images/articles/8700k_sm.jpg"
                    }, 
                    new PcComponent
                    {
                        Name = "ROG STRIX Z370-E GAMING",
                        Brand = "Asus",
                        Price = 248.50m,
                        ShortDescription = "High End Asus Z370 Motherboard support Intel 1151 processors.",
                        LongDescription = "Designed exclusively for 8th generation Intel® Core™ processors to maximize connectivity and speed with Dual M.2, 802.11ac WiFi, Gigabit LAN, front panel USB 3.1 and Intel® Optane™ Memory compatibility",
                        InfoLink = "https://www.asus.com/us/Motherboards/ROG-STRIX-Z370-E-GAMING/specifications",
                        Category = Categories["Motherboard"],
                        ImageUrl = @"/images/articles/ROGZ370E_sm.jpg",
                        InStock = true,
                        IsPreferredPcComponent = true,
                        ImageThumbnailUrl = @"/images/articles/ROGZ370E_sm.jpg"
                    },
                    new PcComponent
                    {
                        Name = "Carbide Series 678C",
                        Brand = "Corsair",
                        Price = 163.30m,
                        ShortDescription = "CORSAIR mid-tower ATX case.",
                        LongDescription = "The CORSAIR Carbide Series 678C is a mid-tower ATX case optimized for quiet operation, blending sophisticated style and a plethora of versatile cooling and storage options.",
                        InfoLink = "https://www.corsair.com/ww/en/Categories/Products/Cases/Mid-Tower-ATX-Cases/Carbide-Series-678C-Low-Noise-Tempered-Glass-ATX-Case/p/CC-9011170-WW#tab-tech-specs",
                        Category = Categories["Case"],
                        ImageUrl = @"/images/articles/Corsair678C_sm.jpg",
                        InStock = true,
                        IsPreferredPcComponent = true,
                        ImageThumbnailUrl = @"/images/articles/Corsair678C_sm.jpg"
                    },
                     new PcComponent
                     {
                         Name = "SSR-650FX",
                         Brand = "Seasonic",
                         Price = 103.44m,
                         ShortDescription = "Seasonic Gold series modular power supply 650W.",
                         LongDescription = "Seasonic engineers have created a brand new product line based on advanced technology emanating from many years of intensive active research. The result of this development is the solid FOCUS+ Series, which implements modern design and shows outstanding electrical performance. This power supply is small and entirely modular, which will be hard to resist. It is available in 80 PLUS® Platinum and Gold efficiency ratings.",
                         InfoLink = "https://seasonic.com/focus-plus-gold#specification",
                         Category = Categories["PSU"],
                         ImageUrl = @"/images/articles/Seasonic650FX_sm.jpg",
                         InStock = true,
                         IsPreferredPcComponent = true,
                         ImageThumbnailUrl = @"/images/articles/Seasonic650FX_sm.jpg"
                     },
                     new PcComponent
                     {
                         Name = "MX Master 2S",
                         Brand = "Logitech",
                         Price = 97.00m,
                         ShortDescription = "High end wireless Logitech mouse.",
                         LongDescription = "Logitech’s flagship mouse is designed for power users and masters of their craft who want to get more done, more efficiently. MX Master 2S packs a punch with Logitech Flow that lets you seamlessly control two computers with one mouse and copy-paste content between them. Combined with other advanced features and a stunning design, it provides exceptional comfort, control, precision and customization.",
                         InfoLink = "https://www.logitech.com/en-us/product/mx-master-2s-flow?crid=7",
                         Category = Categories["Mouse"],
                         ImageUrl = @"/images/articles/LogitechMX2S_sm.jpg",
                         InStock = true,
                         IsPreferredPcComponent = true,
                         ImageThumbnailUrl = @"/images/articles/LogitechMX2S_sm.jpg"
                     },
                     new PcComponent
                     {
                         Name = "G512 Carbon",
                         Brand = "Logitech",
                         Price = 82.50m,
                         ShortDescription = "Gaming series mechanical keyboard.",
                         LongDescription = "G512 is a high-performance gaming keyboard featuring your choice of advanced Romer-G Tactile, Romer-G Linear and GX Blue mechanical switches. Advanced gaming technology and aluminum-alloy construction make G512 simple, durable and full-featured.",
                         InfoLink = "https://www.logitechg.com/en-us/products/gaming-keyboards/g512-mechanical-gaming-keyboard.html",
                         Category = Categories["Keyboard"],
                         ImageUrl = @"/images/articles/LogitechG512_sm.jpg",
                         InStock = true,
                         IsPreferredPcComponent = true,
                         ImageThumbnailUrl = @"/images/articles/LogitechG512_sm.jpg"
                     },
                     new PcComponent
                     {
                         Name = "HyperX FURY DDR4 8GB 3200MHz",
                         Brand = "Kingston",
                         Price = 49.90m,
                         ShortDescription = "High performance DDR4 Memory",
                         LongDescription = "HyperX® FURY DDR4 auto-overclocks itself to the highest published frequency, up to 3466MHz1, providing a Plug N Play boost for gaming, video editing and rendering. It’s XMP-ready and available in 2400MHz–3466MHz speeds, CL15–19 latencies, single-module capacities of 4GB–16GB and kit capacities of 16GB–64GB. It’s also compatible with the latest Intel processors and most of the newest AMD CPU technologies. HyperX FURY DDR4 stays cool with its stylish, low-profile heat spreader. One hundred per cent tested at speed and backed by a lifetime warranty, FURY DDR4 is your worry-free, cost-effective upgrade of choice.",
                         InfoLink = "https://www.hyperxgaming.com/en/memory/fury-ddr4",
                         Category = Categories["RAM"],
                         ImageUrl = @"/images/articles/KingstonDDR4_8GB_3200_sm.jpg",
                         InStock = true,
                         IsPreferredPcComponent = true,
                         ImageThumbnailUrl = @"/images/articles/KingstonDDR4_8GB_3200_sm.jpg"
                     },
                     new PcComponent
                     {
                         Name = "NITRO+ RX 580 8G G5",
                         Brand = "Sapphire",
                         Price = 263.90m,
                         ShortDescription = "AMD Radeon RX580 Graphic Card",
                         LongDescription = "The Graphics card is more than just another component; it’s the beating heart of your gaming system. With tasteful shroud design augmented by RGB LEDs', each card is practically a piece of art.",
                         InfoLink= "https://www.sapphiretech.com/en/consumer/nitro-rx-580-8g-g5",
                         Category = Categories["Video Card"],
                         ImageUrl = @"/images/articles/NitroRX580_8G_sm.jpg",
                         InStock = false,
                         IsPreferredPcComponent = false,
                         ImageThumbnailUrl = @"/images/articles/NitroRX580_8G_sm.jpg"
                     }
                );
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Monitor" },
                        new Category { CategoryName = "Motherboard" },
                        new Category { CategoryName = "CPU" },
                        new Category { CategoryName = "Case" },
                        new Category { CategoryName = "PSU" },
                        new Category { CategoryName = "Mouse" },
                        new Category { CategoryName = "Keyboard" },
                        new Category { CategoryName = "Video Card" },
                        new Category { CategoryName = "RAM" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
