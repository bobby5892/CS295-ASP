class Messages {
    constructor(){
        // Quick Reference
            // Tabs
        this.tabCompose = document.getElementById("TabCompose");
        this.tabIncoming = document.getElementById("TabIncoming");
        this.tabSent = document.getElementById("TabSent");
            // Buttons
        this.buttonCompose = document.getElementById("btnCompose");
        this.buttonIncoming = document.getElementById("btnIncoming");
        this.buttonSent = document.getElementById("btnSent");
            // Wells
        this.wellIncoming = document.getElementById("incomingMessages");
        this.wellOutogoing = document.getElementById("outgoingMessages");
        this.wellCompose = document.getElementById("composeMessage");

        // Show What we want
        this.wellIncoming.style.display = "block";
        this.activateTab(this.tabIncoming);
        // Add Listeners
        this.buttonCompose.addEventListener("click", () => {
            this.hideAll();
            this.show(this.wellCompose);
            this.activateTab(this.tabCompose);
        });
        this.buttonIncoming.addEventListener("click", () => {
            this.hideAll();
            this.show(this.wellIncoming);
            this.activateTab(this.tabIncoming );
        });
        this.buttonSent.addEventListener("click", () => {
            this.hideAll();
            this.show(this.wellOutogoing);
            this.activateTab(this.tabSent);
        });
    }
    // Hide all Wells
    hideAll() {
        this.hide(this.wellIncoming);
        this.hide(this.wellOutogoing);
        this.hide(this.wellCompose);
        // Hide all Tabs
        this.deactiveateAllTabs();
    }
    // Hide a bootstrap well
    hide(el) {
        el.style.display = "none";
    }
    show(el) {
        el.style.display = "block";
    }
    // Mark all tabs inactive
    deactiveateAllTabs() {
        this.deactivateTab(this.tabCompose);
        this.deactivateTab(this.tabIncoming);
        this.deactivateTab(this.tabSent);
    }
    // mark a tab inactive
    deactivateTab(el) {
        el.classList.remove("active");
    }
    // mark a tab active
    activateTab(el) {
        el.classList.add("active");
    }
}

window.addEventListener("load", () => {
    messages = new Messages();
});