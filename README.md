Affordable AIO Bot, sneaker bot coded in VB.Net.
#
Status: **Under Development**
#
**Completed List:**
- Account Add Form
 - User can add normal accounts or guest accounts.
 - Fields: guest, email, password, size, site, link, keyword, checkout profile, notification e-mail, phone carrier, and notification number.
 
- About Form
 - Descriptions about the bot.
 
- Browser Form
 - Display the added item in cart. If user wants to see it.
 
- Cart Form
 - Display currently carted items with time, product name, email, size, and site.
 
- Checkout Add Form
 - User can add checkout profiles. Use for auto checkout.
 - Fields: profile name, first name, last name, address 1, address 2, zip code, city, US states, country, phone, email, card type, card number, expire date, and cvv.
 
- Keyword Edit Form
 - User can edit keywords.

- Link Edit Form
 - User can edit links.

- Login Form
 - Authenticate users using backend server.
 - Check if user is banned. If so, displays the reason.
 - One license per computer, validated using HWID.
 
- Main Form
 - Main form where users can add, remove, edit, and clone accounts and checkout profiles.
 - Import and export accounts and checkout profiles.
 - Account and checkout profiles are seprated by tabs. Also has a log tab for logs.
 - Link to the Cart Form, Proxy Form, Tips Form.
 - Included a wyUpdate button to check for updates and install it.
 
- Maintenance Form
 - Check if the bot is currently under maintenance.
 
- Proxy Form
 - User can paste proxies in here using following format: ip address:port:username:password.
 - User can test proxy againt sites to see if the proxy is blocked/banned and see the ping.

- Site Edit Form
 - User can edit sites.
 
- Size Edit Form
 - User can edit sizes.
 
- Tips Form
 - User can see tips or any release information.

- Uses wyUpdate to push updates.

- All files are saved and loaded to/from a .csv file for easy edit.

- When program closes all current data will be autosaved onto the following file:
 - autosaveaccount.csv
 - autosavecheckout.csv
 - autosaveproxy.csv
 
- Added right click functions to remove, clone, import, export, remove all, and edit all for size, site, link, keyword.
 
#
**To-Do List:**

- Finish GUI part.
- Add selected edit functions.
- Add proxy test against sites to see if it is blocked/banned and display ping.
- Coding adding to cart functions.
- Make start and stop button work.
- Fix any bugs / errors.